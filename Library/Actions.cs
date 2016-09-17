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
    public partial class Actions : Form
    {
        public Actions()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            if (rdoSearchBooks.Checked)
            {
                SearchBooks srch = new SearchBooks();
                srch.ShowDialog();
            }
            if (rdoReturn.Checked)
            {
                ReturnBooks ret = new ReturnBooks();
                ret.ShowDialog();
            }
            if (rdoAddBooks.Checked)
            {
                AddBooks add = new AddBooks();
                add.ShowDialog();
            }
            if (rdoCategory.Checked)
            {
                Category cat = new Category();
                cat.ShowDialog();

            }
            if (rdoChgPwd.Checked)
            {
                ChangePassword pwd = new ChangePassword();
                pwd.ShowDialog();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            LoginPage frmLogin = new LoginPage();
            frmLogin.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }
    }
}
