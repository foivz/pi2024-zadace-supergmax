using Evaluation_Manager.Repositories;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace Evaluation_Manager
{
    public partial class FrmOrderMeal : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        private User loggedInUser;

        public FrmOrderMeal(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            LoadMealList();
        }

        public FrmOrderMeal(User user, FrmPreferences preferencesForm) : this(user)
        {
            preferencesForm.PreferencesUpdated += PreferencesForm_PreferencesUpdated;
        }

        private void PreferencesForm_PreferencesUpdated(object sender, EventArgs e)
        {
            LoadMealList();
        }

        private void LoadMealList()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = @"
            SELECT DISTINCT ml.MealID, ml.MealName, ml.Description 
            FROM MealList ml
            WHERE NOT EXISTS (
                SELECT 1
                FROM MealFoodSpecification mfs
                WHERE ml.MealID = mfs.MealID
                AND mfs.FoodSpecID NOT IN (
                    SELECT FoodSpecID
                    FROM FoodSpecification
                    WHERE UserID = @UserID
                )
            )";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@UserID", loggedInUser.UserID);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable mealTable = new DataTable();
                        adapter.Fill(mealTable);
                        dgvMealList.DataSource = mealTable;
                    }
                }
            }
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (dgvMealList.SelectedRows.Count > 0)
            {
                int mealID = Convert.ToInt32(dgvMealList.SelectedRows[0].Cells["MealID"].Value);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO OrderedMeal (UserID, MealID, OrderDate) VALUES (@UserID, @MealID, @OrderDate)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", loggedInUser.UserID);
                        command.Parameters.AddWithValue("@MealID", mealID);
                        command.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Meal ordered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a meal to order.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmStudentMenu frmStudentMenu = new FrmStudentMenu(loggedInUser);
            frmStudentMenu.Show();
            this.Close();
        }
    }

}
