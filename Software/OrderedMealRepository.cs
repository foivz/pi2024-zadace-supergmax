using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class OrderedMealRepository : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;

        public OrderedMealRepository()
        {
            InitializeComponent();
        }

        public void AddOrderedMeal(int userID, int mealID, DateTime orderDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO OrderedMeal (UserID, MealID, OrderDate) VALUES (@UserID, @MealID, @OrderDate)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@MealID", mealID);
                    command.Parameters.AddWithValue("@OrderDate", orderDate);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
