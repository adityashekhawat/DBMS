namespace Library
{
    partial class AddBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtViewCat = new System.Windows.Forms.TextBox();
            this.lblViewCat = new System.Windows.Forms.Label();
            this.txtViewAuthor = new System.Windows.Forms.TextBox();
            this.lblViewAuthor = new System.Windows.Forms.Label();
            this.txtRemQty = new System.Windows.Forms.TextBox();
            this.lblRemQty = new System.Windows.Forms.Label();
            this.txtAvailQty = new System.Windows.Forms.TextBox();
            this.lblAvlQty = new System.Windows.Forms.Label();
            this.cmbRemoveBook = new System.Windows.Forms.ComboBox();
            this.grpRemove = new System.Windows.Forms.GroupBox();
            this.lblRemBook = new System.Windows.Forms.Label();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblcat = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpRemove.SuspendLayout();
            this.grpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(346, 502);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(72, 24);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "&Remove";
            // 
            // txtViewCat
            // 
            this.txtViewCat.Location = new System.Drawing.Point(159, 72);
            this.txtViewCat.Name = "txtViewCat";
            this.txtViewCat.ReadOnly = true;
            this.txtViewCat.Size = new System.Drawing.Size(176, 20);
            this.txtViewCat.TabIndex = 3;
            // 
            // lblViewCat
            // 
            this.lblViewCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewCat.Location = new System.Drawing.Point(17, 72);
            this.lblViewCat.Name = "lblViewCat";
            this.lblViewCat.Size = new System.Drawing.Size(112, 32);
            this.lblViewCat.TabIndex = 2;
            this.lblViewCat.Text = "Category";
            // 
            // txtViewAuthor
            // 
            this.txtViewAuthor.Location = new System.Drawing.Point(160, 116);
            this.txtViewAuthor.Name = "txtViewAuthor";
            this.txtViewAuthor.ReadOnly = true;
            this.txtViewAuthor.Size = new System.Drawing.Size(176, 20);
            this.txtViewAuthor.TabIndex = 5;
            // 
            // lblViewAuthor
            // 
            this.lblViewAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAuthor.Location = new System.Drawing.Point(18, 116);
            this.lblViewAuthor.Name = "lblViewAuthor";
            this.lblViewAuthor.Size = new System.Drawing.Size(112, 32);
            this.lblViewAuthor.TabIndex = 4;
            this.lblViewAuthor.Text = "Author Name";
            // 
            // txtRemQty
            // 
            this.txtRemQty.Location = new System.Drawing.Point(160, 195);
            this.txtRemQty.Name = "txtRemQty";
            this.txtRemQty.Size = new System.Drawing.Size(176, 20);
            this.txtRemQty.TabIndex = 9;
            // 
            // lblRemQty
            // 
            this.lblRemQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemQty.Location = new System.Drawing.Point(20, 195);
            this.lblRemQty.Name = "lblRemQty";
            this.lblRemQty.Size = new System.Drawing.Size(112, 40);
            this.lblRemQty.TabIndex = 8;
            this.lblRemQty.Text = "Quantity To Be Removed Of Book Selected ";
            // 
            // txtAvailQty
            // 
            this.txtAvailQty.Location = new System.Drawing.Point(160, 155);
            this.txtAvailQty.Name = "txtAvailQty";
            this.txtAvailQty.ReadOnly = true;
            this.txtAvailQty.Size = new System.Drawing.Size(176, 20);
            this.txtAvailQty.TabIndex = 7;
            // 
            // lblAvlQty
            // 
            this.lblAvlQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvlQty.Location = new System.Drawing.Point(20, 155);
            this.lblAvlQty.Name = "lblAvlQty";
            this.lblAvlQty.Size = new System.Drawing.Size(112, 32);
            this.lblAvlQty.TabIndex = 6;
            this.lblAvlQty.Text = "Quantity Available Of Book Selected ";
            // 
            // cmbRemoveBook
            // 
            this.cmbRemoveBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRemoveBook.Location = new System.Drawing.Point(160, 32);
            this.cmbRemoveBook.Name = "cmbRemoveBook";
            this.cmbRemoveBook.Size = new System.Drawing.Size(176, 21);
            this.cmbRemoveBook.TabIndex = 1;
            // 
            // grpRemove
            // 
            this.grpRemove.Controls.Add(this.txtViewCat);
            this.grpRemove.Controls.Add(this.lblViewCat);
            this.grpRemove.Controls.Add(this.txtViewAuthor);
            this.grpRemove.Controls.Add(this.lblViewAuthor);
            this.grpRemove.Controls.Add(this.txtRemQty);
            this.grpRemove.Controls.Add(this.lblRemQty);
            this.grpRemove.Controls.Add(this.txtAvailQty);
            this.grpRemove.Controls.Add(this.lblAvlQty);
            this.grpRemove.Controls.Add(this.cmbRemoveBook);
            this.grpRemove.Controls.Add(this.lblRemBook);
            this.grpRemove.Location = new System.Drawing.Point(65, 248);
            this.grpRemove.Name = "grpRemove";
            this.grpRemove.Size = new System.Drawing.Size(352, 245);
            this.grpRemove.TabIndex = 8;
            this.grpRemove.TabStop = false;
            this.grpRemove.Text = "Remove Books";
            // 
            // lblRemBook
            // 
            this.lblRemBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemBook.Location = new System.Drawing.Point(20, 32);
            this.lblRemBook.Name = "lblRemBook";
            this.lblRemBook.Size = new System.Drawing.Size(112, 21);
            this.lblRemBook.TabIndex = 0;
            this.lblRemBook.Text = "Book Title";
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.txtTitle);
            this.grpAdd.Controls.Add(this.txtQty);
            this.grpAdd.Controls.Add(this.txtAuthor);
            this.grpAdd.Controls.Add(this.lblQty);
            this.grpAdd.Controls.Add(this.cmbCat);
            this.grpAdd.Controls.Add(this.lblTitle);
            this.grpAdd.Controls.Add(this.lblAuthor);
            this.grpAdd.Controls.Add(this.lblcat);
            this.grpAdd.Location = new System.Drawing.Point(65, 35);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(352, 170);
            this.grpAdd.TabIndex = 6;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Add Books";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(160, 21);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(176, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(160, 141);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(176, 20);
            this.txtQty.TabIndex = 7;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(160, 61);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(176, 20);
            this.txtAuthor.TabIndex = 3;
            // 
            // lblQty
            // 
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(24, 141);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(112, 24);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "Quantity";
            // 
            // cmbCat
            // 
            this.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCat.Location = new System.Drawing.Point(160, 101);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(176, 21);
            this.cmbCat.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(24, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(112, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Book Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(24, 61);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(112, 24);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author Name";
            // 
            // lblcat
            // 
            this.lblcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcat.Location = new System.Drawing.Point(24, 101);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(112, 24);
            this.lblcat.TabIndex = 4;
            this.lblcat.Text = "Category";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(274, 549);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 24);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(186, 549);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(72, 24);
            this.btnAction.TabIndex = 10;
            this.btnAction.Text = "A&ctions";
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(346, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 24);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 609);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.grpRemove);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddBooks";
            this.Text = "AddBooks";
            this.grpRemove.ResumeLayout(false);
            this.grpRemove.PerformLayout();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtViewCat;
        private System.Windows.Forms.Label lblViewCat;
        private System.Windows.Forms.TextBox txtViewAuthor;
        private System.Windows.Forms.Label lblViewAuthor;
        private System.Windows.Forms.TextBox txtRemQty;
        private System.Windows.Forms.Label lblRemQty;
        private System.Windows.Forms.TextBox txtAvailQty;
        private System.Windows.Forms.Label lblAvlQty;
        private System.Windows.Forms.ComboBox cmbRemoveBook;
        private System.Windows.Forms.GroupBox grpRemove;
        private System.Windows.Forms.Label lblRemBook;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblcat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnAdd;
    }
}