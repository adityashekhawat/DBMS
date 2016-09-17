using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void user_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_text_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void login_button_Click(object sender, EventArgs e)
        {
            if(user_text.Text == "" )
            {
                MessageBox.Show("Please enter the Username", "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if(pass_text.Text == "")
            {
                MessageBox.Show("Please enter the Password", "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bool IsSuccesfulLogin = false;
            try
            {
                // Validates User 
                IsSuccesfulLogin = Global.ValidateId(user_text.Text, pass_text.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                this.Dispose();
                Application.Exit();
                return;
            }
            if (!IsSuccesfulLogin)
            {
                MessageBox.Show("Please Enter Valid User Name/Password Combination", "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pass_text.Text = "";
                user_text.Text = "";
                user_text.Focus();
                return;
            }
            else
            {
                Global.Username = user_text.Text;
                Global.Password = pass_text.Text;
                // Launch Action Form
                this.Hide();
                Actions act = new Actions();
                act.ShowDialog();

            }

            /*

            else if(user_text.Text != Global.Username || pass_text.Text != Global.Password)
            {
                MessageBox.Show("Username / Password Incorrect", "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            /*else if (user_text.Text == Global.Username && pass_text.Text == Global.Password)
            {
                this.Close();
                this.Dispose();
                Actions act = new Actions();
                this.Hide();
                act.ShowDialog();
            }*/
            /*
            else
            {
                Global.Username = user_text.Text;
                Global.Password = pass_text.Text;
                // Launch Action Form
                this.Close();
                this.Dispose();
                Actions act = new Actions();
                act.ShowDialog();
            }
            */

        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterUser regUser = new RegisterUser();
            regUser.Show();
        }
    }
}
