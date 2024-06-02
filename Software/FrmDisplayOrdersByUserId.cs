using Evaluation_Manager.Repositories;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace Evaluation_Manager
{
    public partial class FrmDisplayOrdersByUserId : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        private User loggedInUser;

        public FrmDisplayOrdersByUserId(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        private void btnLoadOrders_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM OrderedMeal WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@UserID", int.Parse(txtUserId.Text));
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable orderTable = new DataTable();
                        adapter.Fill(orderTable);
                        dgvOrders.DataSource = orderTable;
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAdminMenu frmAdminMenu = new FrmAdminMenu(loggedInUser);
            frmAdminMenu.Show();
            this.Close();
        }

        private void txtUserId_Enter(object sender, EventArgs e)
        {
            if (txtUserId.Text == "User ID")
            {
                txtUserId.Text = "";
                txtUserId.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtUserId_Leave(object sender, EventArgs e)
        {
            if (txtUserId.Text == "")
            {
                txtUserId.Text = "User ID";
                txtUserId.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
