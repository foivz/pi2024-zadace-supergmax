using System;
using System.Windows.Forms;
using Evaluation_Manager.Repositories;

namespace Evaluation_Manager
{
    public partial class FrmLogin : Form
    {
        public static User LoggedUser { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username was not entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password was not entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var user = UserRepository.GetUser(txtUsername.Text);

                if (user != null && txtPassword.Text == user.Password)
                {
                    if (user.Role == "Admin")
                    {
                        FrmAdminMenu frmAdminMenu = new FrmAdminMenu(user);
                        frmAdminMenu.Show();
                    }
                    else
                    {
                        FrmStudentMenu frmStudentMenu = new FrmStudentMenu(user);
                        frmStudentMenu.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Ajoutez votre code de gestion d'événement ici, si nécessaire.
        }
    }
}
