
namespace BankApplikáció
{
    partial class loginForm
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
            this.usernameLb = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.adminLb = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameLb
            // 
            this.usernameLb.AutoSize = true;
            this.usernameLb.Location = new System.Drawing.Point(34, 109);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(107, 17);
            this.usernameLb.TabIndex = 0;
            this.usernameLb.Text = "Felhasználónév";
            this.usernameLb.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(34, 149);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(48, 17);
            this.passwordLb.TabIndex = 1;
            this.passwordLb.Text = "Jelszó";
            this.passwordLb.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(37, 210);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(141, 30);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Bejelentkezés";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // adminLb
            // 
            this.adminLb.AutoSize = true;
            this.adminLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adminLb.Location = new System.Drawing.Point(32, 40);
            this.adminLb.Name = "adminLb";
            this.adminLb.Size = new System.Drawing.Size(73, 25);
            this.adminLb.TabIndex = 3;
            this.adminLb.Text = "Admin";
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(181, 106);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(234, 22);
            this.usernameTb.TabIndex = 4;
            this.usernameTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(181, 149);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(234, 22);
            this.passwordTb.TabIndex = 5;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(451, 401);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.adminLb);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.usernameLb);
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLb;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label adminLb;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox passwordTb;
    }
}