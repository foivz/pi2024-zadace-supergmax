using Evaluation_Manager.Repositories;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmStudentMenu : Form
    {
        private User loggedInUser;

        public FrmStudentMenu(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void btnOrderMeal_Click(object sender, EventArgs e)
        {
            FrmPreferences preferencesForm = new FrmPreferences(loggedInUser);
            FrmOrderMeal frmOrderMeal = new FrmOrderMeal(loggedInUser, preferencesForm);
            frmOrderMeal.Show();
            this.Hide();
        }

        private void btnLastOrders_Click(object sender, EventArgs e)
        {
            FrmLastOrders frmLastOrders = new FrmLastOrders(loggedInUser);
            frmLastOrders.Show();
            this.Hide();
        }

        private void btnPreferences_Click(object sender, EventArgs e)
        {
            FrmPreferences frmPreferences = new FrmPreferences(loggedInUser);
            frmPreferences.PreferencesUpdated += PreferencesForm_PreferencesUpdated;
            frmPreferences.Show();
            this.Hide();
        }

        private void PreferencesForm_PreferencesUpdated(object sender, EventArgs e)
        {
            // Logic to handle preference updates if needed
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }
    }

}
