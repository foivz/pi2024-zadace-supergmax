using Evaluation_Manager.Repositories;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace Evaluation_Manager
{
    public partial class FrmAddUser : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        private User loggedInUser;

        public FrmAddUser(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Username", txtUsername.Text);
                    command.Parameters.AddWithValue("@Password", txtPassword.Text);
                    command.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString());
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAdminMenu frmAdminMenu = new FrmAdminMenu(loggedInUser);
            frmAdminMenu.Show();
            this.Close();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
