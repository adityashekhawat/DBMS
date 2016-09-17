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
    public partial class SearchBooks : Form
    {
        public SearchBooks()
        {
            InitializeComponent();
        }

        private void txtBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Actions frmLogin = new Actions();
            frmLogin.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
