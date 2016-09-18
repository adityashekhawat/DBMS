using System;
using System.Collections;
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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Actions frmLogin = new Actions();
            frmLogin.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Book Title", "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtAuthor.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Author Name", "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtQty.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Quantity of books in numeric format", "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                bool isNumber = isNumeric(txtQty.Text, System.Globalization.NumberStyles.Integer);
                if (!isNumber)
                {
                    MessageBox.Show("Please Enter Quantity of books in numeric format", "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            
            bool IsSuccesfulAdd = false;
            bool isNewEntry = true;
            try
            {
                isNewEntry = Global.CheckNewEntry(txtTitle.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Library Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                this.Dispose();
                Application.Exit();
                return;
            }

            if (isNewEntry)
            {
                // then add the new entry in the table

                int qty = Convert.ToInt32(txtQty.Text);                

                try
                {
                    IsSuccesfulAdd = Global.AddBook(txtTitle.Text, txtAuthor.Text, qty, cmbCat.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    this.Dispose();
                    Application.Exit();
                    return;
                }
                if (!IsSuccesfulAdd)
                {
                    MessageBox.Show("Failed", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Book successfully Added", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    this.Dispose();
                    Actions frm = new Actions();
                    frm.Show();
                }
            }

            else
            {
                // just increment the existing value of quantity
                bool valueIncremented = false;
                int qty = Convert.ToInt32(txtQty.Text);
                try
                {
                    valueIncremented = Global.IncrementQuantity(qty,txtTitle.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    this.Dispose();
                    Application.Exit();
                    return;
                }
                if (!valueIncremented)
                {
                    MessageBox.Show("Failed", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Book successfully Added", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    this.Dispose();
                    Actions frm = new Actions();
                    frm.Show();
                }
            }
        }

        private bool isNumeric(string val, System.Globalization.NumberStyles NumberStyle)
        {
            int result;
            return int.TryParse(val, NumberStyle, System.Globalization.CultureInfo.CurrentCulture, out result);
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.lib_category' table. You can move, or remove it, as needed.
            this.lib_categoryTableAdapter.Fill(this.libraryDBDataSet.lib_category);

        }
        
    }
    }

