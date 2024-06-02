using Evaluation_Manager.Repositories;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace Evaluation_Manager
{
    public partial class FrmPreferences : Form
    {
        public delegate void PreferencesUpdatedHandler(object sender, EventArgs e);
        public event PreferencesUpdatedHandler PreferencesUpdated;

        private string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        private User loggedInUser;

        public FrmPreferences(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            LoadFoodPreferences();
        }

        private void LoadFoodPreferences()
        {
            clbFoodPreferences.Items.Clear(); // Nettoyer les éléments existants

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT FoodSpecID FROM FoodSpecification WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@UserID", loggedInUser.UserID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Dictionary<int, string> foodPreferenceIDs = new Dictionary<int, string>
                    {
                        { 1, "Vegetarian" },
                        { 2, "Vegan" },
                        { 3, "Gluten-Free" }
                    };

                        while (reader.Read())
                        {
                            int foodSpecID = reader.GetInt32(0);
                            if (foodPreferenceIDs.ContainsKey(foodSpecID))
                            {
                                clbFoodPreferences.Items.Add(foodPreferenceIDs[foodSpecID], true);
                            }
                        }
                    }
                }

                // Ajouter les autres préférences disponibles si elles n'existent pas déjà
                if (!clbFoodPreferences.Items.Contains("Vegetarian"))
                {
                    clbFoodPreferences.Items.Add("Vegetarian", false);
                }
                if (!clbFoodPreferences.Items.Contains("Gluten-Free"))
                {
                    clbFoodPreferences.Items.Add("Gluten-Free", false);
                }
                if (!clbFoodPreferences.Items.Contains("Vegan"))
                {
                    clbFoodPreferences.Items.Add("Vegan", false);
                }
            }
        }

        private void btnSavePreferences_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Supprimer les anciennes préférences alimentaires pour l'utilisateur
                    string deleteFoodSpecSql = "DELETE FROM FoodSpecification WHERE UserID = @UserID";
                    using (SqlCommand deleteFoodSpecCommand = new SqlCommand(deleteFoodSpecSql, connection))
                    {
                        deleteFoodSpecCommand.Parameters.AddWithValue("@UserID", loggedInUser.UserID);
                        deleteFoodSpecCommand.ExecuteNonQuery();
                    }

                    // Définir les ID pour les types de préférence alimentaire
                    Dictionary<string, int> foodPreferenceIDs = new Dictionary<string, int>
                {
                    { "Vegetarian", 1 },
                    { "Vegan", 2 },
                    { "Gluten-Free", 3 }
                };

                    // Insérer les nouvelles préférences alimentaires
                    string insertFoodSpecSql = "INSERT INTO FoodSpecification (UserID, FoodSpecID) VALUES (@UserID, @FoodSpecID)";
                    foreach (var item in clbFoodPreferences.CheckedItems)
                    {
                        if (foodPreferenceIDs.ContainsKey(item.ToString()))
                        {
                            using (SqlCommand insertFoodSpecCommand = new SqlCommand(insertFoodSpecSql, connection))
                            {
                                insertFoodSpecCommand.Parameters.AddWithValue("@UserID", loggedInUser.UserID);
                                insertFoodSpecCommand.Parameters.AddWithValue("@FoodSpecID", foodPreferenceIDs[item.ToString()]);
                                insertFoodSpecCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
                MessageBox.Show("Preferences saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Déclenche l'événement PreferencesUpdated
                PreferencesUpdated?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

