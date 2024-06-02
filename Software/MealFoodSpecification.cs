using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class MealFoodSpecification : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;

        public MealFoodSpecification()
        {
            InitializeComponent();
        }

        public void SaveMealFoodSpecification(int mealID, int foodSpecID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string checkSql = "SELECT COUNT(*) FROM MealFoodSpecification WHERE MealID = @MealID AND FoodSpecID = @FoodSpecID";
                using (SqlCommand checkCommand = new SqlCommand(checkSql, connection))
                {
                    checkCommand.Parameters.AddWithValue("@MealID", mealID);
                    checkCommand.Parameters.AddWithValue("@FoodSpecID", foodSpecID);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        string insertSql = "INSERT INTO MealFoodSpecification (MealID, FoodSpecID) VALUES (@MealID, @FoodSpecID)";
                        using (SqlCommand insertCommand = new SqlCommand(insertSql, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@MealID", mealID);
                            insertCommand.Parameters.AddWithValue("@FoodSpecID", foodSpecID);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
