namespace Library
{
    partial class ReturnBooks
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
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.cmbreturn = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(35, 168);
            this.txtCat.Name = "txtCat";
            this.txtCat.ReadOnly = true;
            this.txtCat.Size = new System.Drawing.Size(176, 20);
            this.txtCat.TabIndex = 10;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(35, 129);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(176, 20);
            this.txtAuthor.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(217, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 24);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(133, 207);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(72, 24);
            this.btnAction.TabIndex = 12;
            this.btnAction.Text = "&Actions";
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(41, 207);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(80, 24);
            this.btnreturn.TabIndex = 11;
            this.btnreturn.Text = "&Return";
            // 
            // cmbreturn
            // 
            this.cmbreturn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbreturn.Location = new System.Drawing.Point(35, 89);
            this.cmbreturn.Name = "cmbreturn";
            this.cmbreturn.Size = new System.Drawing.Size(256, 21);
            this.cmbreturn.TabIndex = 8;
            // 
            // lblSelect
            // 
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(35, 49);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(248, 24);
            this.lblSelect.TabIndex = 7;
            this.lblSelect.Text = "Select Book To Be Returned";
            // 
            // ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 280);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.cmbreturn);
            this.Controls.Add(this.lblSelect);
            this.Name = "ReturnBooks";
            this.Text = "ReturnBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.ComboBox cmbreturn;
        private System.Windows.Forms.Label lblSelect;
    }
}