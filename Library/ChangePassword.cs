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
    public partial class ChangePassword : Form
    {
        public static string ConnectionString = @"Data Source=ADITYA;Initial Catalog=LibraryDB;Integrated Security=True";
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Actions frmLogin = new Actions();
            frmLogin.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtOld.Text == Global.Password)
            {
                {
                    if(txtNew.Text == "")
                    {
                        MessageBox.Show("Password Feild empty", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(txtNew.Text != txtConfirm.Text)
                    {
                        MessageBox.Show("The passwords don't match", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    else
                    {
                        /*
                        string passwd = txtNew.Text;
                        Global.Password = passwd;
                        this.Close();
                        this.Dispose();
                        Actions frmLogin = new Actions();
                        frmLogin.Show();
                        */
                        bool passwordChanged = false;
                        try
                        {
                            passwordChanged = Global.ChangePassword(txtNew.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                            this.Dispose();
                            Application.Exit();
                            return;
                        }
                        if (!passwordChanged)
                        {
                            MessageBox.Show("Request to change Password Failed", "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Global.Password = txtNew.Text;
                            this.Close();
                            this.Dispose();
                            Actions frmActions = new Actions();
                            frmActions.Show();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Old password Incorrect", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
