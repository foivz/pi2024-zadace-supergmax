using Evaluation_Manager.Repositories;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace Evaluation_Manager
{
    public partial class FrmLastOrders : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        private User loggedInUser;

        public FrmLastOrders(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            LoadOrderedMeals();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmStudentMenu frmStudentMenu = new FrmStudentMenu(loggedInUser);
            frmStudentMenu.Show();
            this.Close();
        }
    }
}
