using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Evaluation_Manager.Repositories
{
    public class MealListRepository
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;

        public static void AddMeal(string mealName, string description)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO MealList (MealName, Description) VALUES (@MealName, @Description)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MealName", mealName);
                    command.Parameters.AddWithValue("@Description", description);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
