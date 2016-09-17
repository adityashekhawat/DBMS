namespace Library
{
    partial class LoginPage
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
            this.user = new System.Windows.Forms.Label();
            this.user_text = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(58, 46);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(55, 13);
            this.user.TabIndex = 0;
            this.user.Text = "Username";
            this.user.Click += new System.EventHandler(this.label1_Click);
            // 
            // user_text
            // 
            this.user_text.Location = new System.Drawing.Point(119, 43);
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(100, 20);
            this.user_text.TabIndex = 1;
            this.user_text.TextChanged += new System.EventHandler(this.user_text_TextChanged);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(58, 100);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(53, 13);
            this.pass.TabIndex = 2;
            this.pass.Text = "Password";
            // 
            // pass_text
            // 
            this.pass_text.Location = new System.Drawing.Point(119, 97);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(100, 20);
            this.pass_text.TabIndex = 3;
            this.pass_text.UseSystemPasswordChar = true;
            this.pass_text.TextChanged += new System.EventHandler(this.pass_text_TextChanged);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(102, 146);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "&Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.ForeColor = System.Drawing.Color.Black;
            this.exit_button.Location = new System.Drawing.Point(166, 226);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(95, 23);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "E&xit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(12, 226);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(75, 23);
            this.register_button.TabIndex = 6;
            this.register_button.Text = "&Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user_text);
            this.Controls.Add(this.user);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox user_text;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button register_button;
    }
}

