using Evaluation_Manager.Repositories;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace Evaluation_Manager
{
    public partial class FrmDisplayAllMeals : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        private User loggedInUser;

        public FrmDisplayAllMeals(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            LoadMeals();
        }

        private void LoadMeals()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = @"
                    SELECT m.MealID, m.MealName, m.Description, f.Description AS FoodSpec
                    FROM MealList m
                    LEFT JOIN MealFoodSpecification mfs ON m.MealID = mfs.MealID
                    LEFT JOIN FoodSpec f ON mfs.FoodSpecID = f.FoodSpecID";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable mealTable = new DataTable();
                        adapter.Fill(mealTable);
                        dgvMeals.DataSource = mealTable;
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAdminMenu frmAdminMenu = new FrmAdminMenu(loggedInUser);
            frmAdminMenu.Show();
            this.Close();
        }
    }
}
