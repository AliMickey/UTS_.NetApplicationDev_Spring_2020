﻿using System;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Login : Form
    {
        public static UserList users = new UserList();

        public Login()
        {
            InitializeComponent();
            users.LoadUsers("login.txt");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            Hide();
            NewUserForm newuserform = new NewUserForm();
            newuserform.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (users.UserExists(txtUsername.Text, txtPassword.Text))
            {
                Hide();
                TextEditorForm texteditorform = new TextEditorForm(txtUsername.Text, users.UserType(txtUsername.Text));
                texteditorform.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials\n\nPlease Try Again", "Error");
            } 
        }
    }
}
