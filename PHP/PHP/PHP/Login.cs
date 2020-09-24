using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool LoginValid(string username, string password)
        {
            string[] usernames = { "admin", "employee1", "employee2" };
            string[] passwords = { "password", "password1", "password2" };

            return (usernames.Contains(username) && passwords.Contains(password));

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            //TODO - Check login details from database

            if (LoginValid(login_id_box.Text, login_pass_box.Text))
            {
                //hide login window
                this.Hide();
                // Load main application window
                ParentMDI main = new ParentMDI();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear_btn_Click(sender, e);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            login_id_box.Clear();
            login_pass_box.Clear();
            login_id_box.Focus();
        }
    }
}
