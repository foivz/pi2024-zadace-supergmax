using Evaluation_Manager.Repositories;
using System;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class welcome : Form
    {
        private User loggedInUser;

        public welcome(string username, string role, User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
            UpdateWelcomeMessage(username, role);
        }

        private void UpdateWelcomeMessage(string username, string role)
        {
            label1.Text = $"Welcome {username}! Your role is {role}.";
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Redirection based on user role
            Form nextForm = null;

            if (loggedInUser.Role == "Admin")
            {
                nextForm = new FrmAdmin();
            }
            else if (loggedInUser.Role == "Student")
            {
                nextForm = new FrmStudents(loggedInUser);
            }
            else if (loggedInUser.Role == "Staff")
            {
                nextForm = new FrmStaff();
            }

            if (nextForm != null)
            {
                Hide();
                nextForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid role! Cannot redirect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
