using Evaluation_Manager.Repositories;
using System.Windows.Forms;
using System;

namespace Evaluation_Manager
{
    public partial class FrmAdminMenu : Form
    {
        private User loggedInUser;

        public FrmAdminMenu(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FrmAddUser frmAddUser = new FrmAddUser(loggedInUser);
            frmAddUser.Show();
            this.Hide();
        }

        private void btnDisplayAllUsers_Click(object sender, EventArgs e)
        {
            FrmDisplayAllUsers frmDisplayAllUsers = new FrmDisplayAllUsers(loggedInUser);
            frmDisplayAllUsers.Show();
            this.Hide();
        }

        private void btnDisplayOrdersByUserId_Click(object sender, EventArgs e)
        {
            FrmDisplayOrdersByUserId frmDisplayOrdersByUserId = new FrmDisplayOrdersByUserId(loggedInUser);
            frmDisplayOrdersByUserId.Show();
            this.Hide();
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            FrmAddMeal frmAddMeal = new FrmAddMeal(loggedInUser);
            frmAddMeal.Show();
            this.Hide();
        }

        private void btnDeleteMeal_Click(object sender, EventArgs e)
        {
            FrmDeleteMeal frmDeleteMeal = new FrmDeleteMeal(loggedInUser);
            frmDeleteMeal.Show();
            this.Hide();
        }

        private void btnDisplayUserPreferences_Click(object sender, EventArgs e)
        {
            FrmDisplayUserPreferences frmDisplayUserPreferences = new FrmDisplayUserPreferences(loggedInUser);
            frmDisplayUserPreferences.Show();
            this.Hide();
        }

        private void btnDisplayAllMeals_Click(object sender, EventArgs e)
        {
            FrmDisplayAllMeals frmDisplayAllMeals = new FrmDisplayAllMeals(loggedInUser);
            frmDisplayAllMeals.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }
    }
}
