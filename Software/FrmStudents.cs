using Evaluation_Manager.Repositories;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmStudents : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        private User loggedInUser;

        public FrmStudents(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            LoadMealList();
            LoadOrderedMeals();
        }

        private void LoadMealList()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT MealID, MealName, Description FROM MealList";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    DataTable mealTable = new DataTable();
                    adapter.Fill(mealTable);
                    dgvMealList.DataSource = mealTable;
                }
            }
        }

        private void LoadOrderedMeals()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT om.OrderID, ml.MealName, om.OrderDate FROM OrderedMeal om " +
                             "JOIN MealList ml ON om.MealID = ml.MealID " +
                             "WHERE om.UserID = @UserID";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@UserID", loggedInUser.UserID);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable orderTable = new DataTable();
                        adapter.Fill(orderTable);
                        dgvOrderedMeals.DataSource = orderTable;
                    }
                }
            }
        }

        private void btnOrderMeal_Click(object sender, EventArgs e)
        {
            if (dgvMealList.SelectedRows.Count > 0)
            {
                int mealID = Convert.ToInt32(dgvMealList.SelectedRows[0].Cells["MealID"].Value);
                OrderedMealRepository repository = new OrderedMealRepository();
                repository.AddOrderedMeal(loggedInUser.UserID, mealID, DateTime.Now);
                LoadOrderedMeals();
            }
            else
            {
                MessageBox.Show("Please select a meal to order.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
