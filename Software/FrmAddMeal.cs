using Evaluation_Manager.Repositories;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace Evaluation_Manager
{
    public partial class FrmAddMeal : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        private User loggedInUser;

        public FrmAddMeal(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void btnSaveMeal_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO MealList (MealName, Description) OUTPUT INSERTED.MealID VALUES (@MealName, @Description)";
                int mealID;
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MealName", txtMealName.Text);
                    command.Parameters.AddWithValue("@Description", txtDescription.Text);
                    mealID = (int)command.ExecuteScalar();
                }

                string insertSpecSql = "INSERT INTO MealFoodSpecification (MealID, FoodSpecID) VALUES (@MealID, @FoodSpecID)";
                Dictionary<string, int> foodPreferenceIDs = new Dictionary<string, int>
                {
                    { "Vegetarian", 1 },
                    { "Vegan", 2 },
                    { "Gluten-Free", 3 }
                };

                foreach (var item in clbFoodPreferences.CheckedItems)
                {
                    if (foodPreferenceIDs.ContainsKey(item.ToString()))
                    {
                        using (SqlCommand insertSpecCommand = new SqlCommand(insertSpecSql, connection))
                        {
                            insertSpecCommand.Parameters.AddWithValue("@MealID", mealID);
                            insertSpecCommand.Parameters.AddWithValue("@FoodSpecID", foodPreferenceIDs[item.ToString()]);
                            insertSpecCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
            MessageBox.Show("Meal added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAdminMenu frmAdminMenu = new FrmAdminMenu(loggedInUser);
            frmAdminMenu.Show();
            this.Close();
        }

        private void txtMealName_Enter(object sender, EventArgs e)
        {
            if (txtMealName.Text == "Meal Name")
            {
                txtMealName.Text = "";
                txtMealName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtMealName_Leave(object sender, EventArgs e)
        {
            if (txtMealName.Text == "")
            {
                txtMealName.Text = "Meal Name";
                txtMealName.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            if (txtDescription.Text == "Description")
            {
                txtDescription.Text = "";
                txtDescription.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                txtDescription.Text = "Description";
                txtDescription.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
