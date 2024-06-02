using Evaluation_Manager.Repositories;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace Evaluation_Manager
{
    public partial class FrmDeleteMeal : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        private User loggedInUser;

        public FrmDeleteMeal(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void btnDeleteMeal_Click(object sender, EventArgs e)
        {
            int mealID = int.Parse(txtMealId.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Supprimer les enregistrements associés dans MealFoodSpecification
                string deleteMealFoodSpecSql = "DELETE FROM MealFoodSpecification WHERE MealID = @MealID";
                using (SqlCommand command = new SqlCommand(deleteMealFoodSpecSql, connection))
                {
                    command.Parameters.AddWithValue("@MealID", mealID);
                    command.ExecuteNonQuery();
                }

                // Supprimer l'enregistrement dans MealList
                string deleteMealSql = "DELETE FROM MealList WHERE MealID = @MealID";
                using (SqlCommand command = new SqlCommand(deleteMealSql, connection))
                {
                    command.Parameters.AddWithValue("@MealID", mealID);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Meal deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAdminMenu frmAdminMenu = new FrmAdminMenu(loggedInUser);
            frmAdminMenu.Show();
            this.Close();
        }

        private void txtMealId_Enter(object sender, EventArgs e)
        {
            if (txtMealId.Text == "Meal ID")
            {
                txtMealId.Text = "";
                txtMealId.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtMealId_Leave(object sender, EventArgs e)
        {
            if (txtMealId.Text == "")
            {
                txtMealId.Text = "Meal ID";
                txtMealId.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
