﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flatResponsivDesign
{
    public partial class loginForm : Form
    {
        public static string username;
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string password, confirmPassword;
            username = usernameTxt.Text;
            password = passwordTxt.Text;
            confirmPassword = confirmPasswordTxt.Text;

            if (username == "Hongly")
            {
                if (password == "123")
                {
                    if(confirmPassword == password)
                    {
                        Main_Form main_Form = new Main_Form();
                        main_Form.Show();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Confirm password must be the same as password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid password");
                }
            }
            else
            {
                MessageBox.Show("Invalid!!");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
