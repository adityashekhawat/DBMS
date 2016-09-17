namespace Library
{
    partial class Actions
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
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.rdoChgPwd = new System.Windows.Forms.RadioButton();
            this.rdoAddBooks = new System.Windows.Forms.RadioButton();
            this.rdoCategory = new System.Windows.Forms.RadioButton();
            this.rdoReturn = new System.Windows.Forms.RadioButton();
            this.rdoSearchBooks = new System.Windows.Forms.RadioButton();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.rdoChgPwd);
            this.grpActions.Controls.Add(this.rdoAddBooks);
            this.grpActions.Controls.Add(this.rdoCategory);
            this.grpActions.Controls.Add(this.rdoReturn);
            this.grpActions.Controls.Add(this.rdoSearchBooks);
            this.grpActions.Location = new System.Drawing.Point(64, 52);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(312, 273);
            this.grpActions.TabIndex = 8;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // rdoChgPwd
            // 
            this.rdoChgPwd.Location = new System.Drawing.Point(25, 225);
            this.rdoChgPwd.Name = "rdoChgPwd";
            this.rdoChgPwd.Size = new System.Drawing.Size(256, 24);
            this.rdoChgPwd.TabIndex = 4;
            this.rdoChgPwd.Text = "Change Password";
            // 
            // rdoAddBooks
            // 
            this.rdoAddBooks.Location = new System.Drawing.Point(25, 177);
            this.rdoAddBooks.Name = "rdoAddBooks";
            this.rdoAddBooks.Size = new System.Drawing.Size(256, 24);
            this.rdoAddBooks.TabIndex = 3;
            this.rdoAddBooks.Text = "Add/Remove Books";
            // 
            // rdoCategory
            // 
            this.rdoCategory.Location = new System.Drawing.Point(25, 129);
            this.rdoCategory.Name = "rdoCategory";
            this.rdoCategory.Size = new System.Drawing.Size(256, 24);
            this.rdoCategory.TabIndex = 2;
            this.rdoCategory.Text = "Manage Categories";
            // 
            // rdoReturn
            // 
            this.rdoReturn.Location = new System.Drawing.Point(25, 81);
            this.rdoReturn.Name = "rdoReturn";
            this.rdoReturn.Size = new System.Drawing.Size(256, 24);
            this.rdoReturn.TabIndex = 1;
            this.rdoReturn.Text = "Return Books";
            // 
            // rdoSearchBooks
            // 
            this.rdoSearchBooks.Checked = true;
            this.rdoSearchBooks.Location = new System.Drawing.Point(25, 33);
            this.rdoSearchBooks.Name = "rdoSearchBooks";
            this.rdoSearchBooks.Size = new System.Drawing.Size(256, 24);
            this.rdoSearchBooks.TabIndex = 0;
            this.rdoSearchBooks.TabStop = true;
            this.rdoSearchBooks.Text = "Search/Issue Books";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(64, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(312, 23);
            this.lblWelcome.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(277, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(89, 340);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "&Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Actions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 418);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Name = "Actions";
            this.Text = "Actions";
            this.grpActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.RadioButton rdoChgPwd;
        private System.Windows.Forms.RadioButton rdoAddBooks;
        private System.Windows.Forms.RadioButton rdoCategory;
        private System.Windows.Forms.RadioButton rdoReturn;
        private System.Windows.Forms.RadioButton rdoSearchBooks;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOk;
    }
}