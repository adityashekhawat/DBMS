namespace Library
{
    partial class ChangePassword
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblOld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(106, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(213, 138);
            this.txtConfirm.MaxLength = 8;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(100, 20);
            this.txtConfirm.TabIndex = 13;
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(213, 98);
            this.txtNew.MaxLength = 8;
            this.txtNew.Name = "txtNew";
            this.txtNew.PasswordChar = '*';
            this.txtNew.Size = new System.Drawing.Size(100, 20);
            this.txtNew.TabIndex = 11;
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(214, 58);
            this.txtOld.MaxLength = 8;
            this.txtOld.Name = "txtOld";
            this.txtOld.PasswordChar = '*';
            this.txtOld.Size = new System.Drawing.Size(100, 20);
            this.txtOld.TabIndex = 9;
            // 
            // lblNew
            // 
            this.lblNew.Location = new System.Drawing.Point(61, 102);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(100, 23);
            this.lblNew.TabIndex = 10;
            this.lblNew.Text = "New Password";
            // 
            // lblConfirm
            // 
            this.lblConfirm.Location = new System.Drawing.Point(61, 146);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(136, 23);
            this.lblConfirm.TabIndex = 12;
            this.lblConfirm.Text = "Confirm New Password";
            // 
            // lblOld
            // 
            this.lblOld.Location = new System.Drawing.Point(61, 58);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(100, 23);
            this.lblOld.TabIndex = 8;
            this.lblOld.Text = "Old Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 298);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.txtOld);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblOld);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblOld;
    }
}