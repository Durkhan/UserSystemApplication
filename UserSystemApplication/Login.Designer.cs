
namespace UserSystemApplication
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
            this.components = new System.ComponentModel.Container();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.lb_register = new System.Windows.Forms.Label();
            this.error_login = new System.Windows.Forms.Label();
            this.login_check_errortimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.White;
            this.lb_username.Location = new System.Drawing.Point(71, 55);
            this.lb_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(119, 26);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Username:";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.ForeColor = System.Drawing.Color.White;
            this.lb_password.Location = new System.Drawing.Point(76, 97);
            this.lb_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(114, 26);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "Password:";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(190, 55);
            this.tb_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(188, 28);
            this.tb_username.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(190, 97);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(188, 28);
            this.tb_password.TabIndex = 3;
            // 
            // bt_login
            // 
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ForeColor = System.Drawing.Color.White;
            this.bt_login.Location = new System.Drawing.Point(321, 152);
            this.bt_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(56, 30);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // lb_register
            // 
            this.lb_register.AutoSize = true;
            this.lb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_register.ForeColor = System.Drawing.Color.White;
            this.lb_register.Location = new System.Drawing.Point(140, 202);
            this.lb_register.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(177, 20);
            this.lb_register.TabIndex = 5;
            this.lb_register.Text = "Don\'t account?Register";
            this.lb_register.Click += new System.EventHandler(this.lb_register_Click);
            // 
            // error_login
            // 
            this.error_login.AutoSize = true;
            this.error_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_login.ForeColor = System.Drawing.Color.Red;
            this.error_login.Location = new System.Drawing.Point(140, 345);
            this.error_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error_login.Name = "error_login";
            this.error_login.Size = new System.Drawing.Size(0, 20);
            this.error_login.TabIndex = 6;
            this.error_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_check_errortimer
            // 
            this.login_check_errortimer.Interval = 900;
            this.login_check_errortimer.Tick += new System.EventHandler(this.login_check_errortimer_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(441, 387);
            this.Controls.Add(this.error_login);
            this.Controls.Add(this.lb_register);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label lb_register;
        private System.Windows.Forms.Label error_login;
        private System.Windows.Forms.Timer login_check_errortimer;
    }
}

