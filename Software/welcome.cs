using System;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class welcome : Form
    {
        private string username;
        private string role;

        public welcome(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
            UpdateWelcomeMessage();
        }

        private void UpdateWelcomeMessage()
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

            if (role == "Admin")
            {
                nextForm = new FrmAdmin();
            }
            else if (role == "Student")
            {
                nextForm = new FrmStudents();
            }
            else if (role == "Staff")
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
