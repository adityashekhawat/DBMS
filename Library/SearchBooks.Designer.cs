namespace Library
{
    partial class SearchBooks
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
            this.lblNote = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(54, 19);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(408, 40);
            this.lblNote.TabIndex = 15;
            this.lblNote.Text = "Note:If Multiple Selection Criteria Are Entered Result Displayed Will Be Retrieve" +
    "d Using And Condition ";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(396, 235);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 24);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "&Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCat);
            this.groupBox1.Controls.Add(this.txtBook);
            this.groupBox1.Controls.Add(this.lblBookName);
            this.groupBox1.Controls.Add(this.lblCat);
            this.groupBox1.Location = new System.Drawing.Point(52, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria-Enter Atleaset One Criteria";
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(216, 85);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(168, 20);
            this.txtCat.TabIndex = 3;
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(216, 39);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(168, 20);
            this.txtBook.TabIndex = 1;
            this.txtBook.TextChanged += new System.EventHandler(this.txtBook_TextChanged);
            // 
            // lblBookName
            // 
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(24, 39);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(100, 23);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Book Name";
            // 
            // lblCat
            // 
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(24, 85);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(100, 23);
            this.lblCat.TabIndex = 2;
            this.lblCat.Text = "Category";
            // 
            // dataGrid1
            // 
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(52, 315);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.PreferredColumnWidth = 94;
            this.dataGrid1.Size = new System.Drawing.Size(416, 149);
            this.dataGrid1.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(396, 475);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 24);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(308, 475);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(72, 24);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "&Actions";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(220, 475);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(72, 24);
            this.btnIssue.TabIndex = 11;
            this.btnIssue.Text = "&Issue";
            // 
            // lblAvailable
            // 
            this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(58, 291);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(408, 23);
            this.lblAvailable.TabIndex = 14;
            this.lblAvailable.Text = "Books Available For Issue (Please select 1 book for issue)";
            // 
            // SearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 518);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.lblAvailable);
            this.Name = "SearchBooks";
            this.Text = "SearchBooks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label lblAvailable;
    }
}