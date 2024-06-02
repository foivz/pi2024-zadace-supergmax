﻿using System;
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
                    LoggedUser = user;

                    // Afficher un pop-up avec le rôle de l'utilisateur
                    MessageBox.Show($"Welcome {user.Username}! Your role is {user.Role}.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmStudents frmStudents = new FrmStudents();
                    Hide();
                    frmStudents.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Wrong credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
