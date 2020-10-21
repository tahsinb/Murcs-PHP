namespace PHP
{
    partial class Login
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
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.login_id_box = new System.Windows.Forms.TextBox();
            this.login_pass_box = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdLabel.Location = new System.Drawing.Point(72, 181);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(76, 24);
            this.UserIdLabel.TabIndex = 0;
            this.UserIdLabel.Text = "User Id";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(72, 264);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(100, 24);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // login_id_box
            // 
            this.login_id_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_id_box.Location = new System.Drawing.Point(76, 208);
            this.login_id_box.Name = "login_id_box";
            this.login_id_box.Size = new System.Drawing.Size(201, 26);
            this.login_id_box.TabIndex = 2;
            // 
            // login_pass_box
            // 
            this.login_pass_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_pass_box.Location = new System.Drawing.Point(76, 291);
            this.login_pass_box.Name = "login_pass_box";
            this.login_pass_box.PasswordChar = '*';
            this.login_pass_box.Size = new System.Drawing.Size(201, 26);
            this.login_pass_box.TabIndex = 3;
            this.login_pass_box.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(131, 352);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 38);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(131, 405);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 38);
            this.clear_btn.TabIndex = 5;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PHP.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(349, 560);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_pass_box);
            this.Controls.Add(this.login_id_box);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserIdLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox login_id_box;
        private System.Windows.Forms.TextBox login_pass_box;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button clear_btn;
    }
}