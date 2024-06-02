using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Evaluation_Manager.Repositories
{
    public class FoodSpecificationRepository : IDisposable
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        private SqlConnection connection;

        public FoodSpecificationRepository()
        {
            connection = new SqlConnection(connectionString);
        }

        public static void AddFoodSpecification(int userId, string specification)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO FoodSpecification (UserID, Specification) VALUES (@UserID, @Specification)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@Specification", specification);
                    command.ExecuteNonQuery();
                }
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (connection != null)
                {
                    connection.Dispose();
                    connection = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
