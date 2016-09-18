using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            LoginPage frmLogin = new LoginPage();
            frmLogin.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtuser.Text == "")
            {
                MessageBox.Show("Enter the username", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtpwd.Text == "" || txtConfirm.Text == "")
            {
                MessageBox.Show("Enter the password", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtpwd.Text != txtConfirm.Text )
            {
                MessageBox.Show("Password Do not match", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool checkUsername = false;
                try
                {
                    checkUsername = Global.CheckUsername(txtuser.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Register User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    this.Dispose();
                    Application.Exit();
                    return;
                }
                if (!checkUsername)
                {
                    bool userRegistered = false;
                    try
                    {
                        userRegistered = Global.RegisterUser(txtuser.Text, txtpwd.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Register User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        this.Dispose();
                        Application.Exit();
                        return;
                    }
                    if (!userRegistered)
                    {
                        MessageBox.Show("User registration failed", "Register User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User registration completed.Please login again", "Register User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        this.Dispose();
                        LoginPage frm = new LoginPage();
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("User Already Present", "Register User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
    }
}
