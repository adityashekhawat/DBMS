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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCatName.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a category ", "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool checkCategory = false;
            try
            {
                checkCategory = Global.CheckCategory(txtCatName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                this.Dispose();
                Application.Exit();
                return;
            }

            if (checkCategory)
            {
                MessageBox.Show("This category already exists. Please enter some other category", "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                bool categoryAdded = false;
                try
                {
                    categoryAdded = Global.AddCategory(txtCatName.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Register User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    this.Dispose();
                    Application.Exit();
                    return;
                }
                if (!categoryAdded)
                {
                    MessageBox.Show("Failed", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Category Successfully Added", "Category Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    this.Dispose();
                    Actions frm = new Actions();
                    frm.Show();
                }
            }
            /*
            else
            {
                MessageBox.Show("Category succesfully entered.", "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Global.CategoryList.Add(Global.CategoryList.Count + 1, txtCatName.Text);
                this.Close();
                this.Dispose();
                Actions act = new Actions();
                act.ShowDialog();
            }
            */
        }
    }
}
