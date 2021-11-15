
namespace UserSystemApplication
{
    partial class Register
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
            this.lb_fullname = new System.Windows.Forms.Label();
            this.lb_regusername = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lbreg_password = new System.Windows.Forms.Label();
            this.tb_fullname = new System.Windows.Forms.RichTextBox();
            this.lb_confirmpassword = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.RichTextBox();
            this.tb_email = new System.Windows.Forms.RichTextBox();
            this.tb_password = new System.Windows.Forms.RichTextBox();
            this.bt_register = new System.Windows.Forms.Button();
            this.check_errors_timer = new System.Windows.Forms.Timer(this.components);
            this.errorOrsucces_msg = new System.Windows.Forms.Label();
            this.tb_confirm_password = new System.Windows.Forms.RichTextBox();
            this.already_account = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.ForeColor = System.Drawing.Color.White;
            this.lb_fullname.Location = new System.Drawing.Point(114, 62);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(141, 32);
            this.lb_fullname.TabIndex = 0;
            this.lb_fullname.Text = "Fullname:";
            // 
            // lb_regusername
            // 
            this.lb_regusername.AutoSize = true;
            this.lb_regusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_regusername.ForeColor = System.Drawing.Color.White;
            this.lb_regusername.Location = new System.Drawing.Point(102, 110);
            this.lb_regusername.Name = "lb_regusername";
            this.lb_regusername.Size = new System.Drawing.Size(153, 32);
            this.lb_regusername.TabIndex = 1;
            this.lb_regusername.Text = "Username:";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.ForeColor = System.Drawing.Color.White;
            this.lb_email.Location = new System.Drawing.Point(160, 159);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(95, 32);
            this.lb_email.TabIndex = 2;
            this.lb_email.Text = "Email:";
            // 
            // lbreg_password
            // 
            this.lbreg_password.AutoSize = true;
            this.lbreg_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbreg_password.ForeColor = System.Drawing.Color.White;
            this.lbreg_password.Location = new System.Drawing.Point(108, 215);
            this.lbreg_password.Name = "lbreg_password";
            this.lbreg_password.Size = new System.Drawing.Size(147, 32);
            this.lbreg_password.TabIndex = 4;
            this.lbreg_password.Text = "Password:";
            // 
            // tb_fullname
            // 
            this.tb_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fullname.Location = new System.Drawing.Point(261, 62);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(287, 37);
            this.tb_fullname.TabIndex = 8;
            this.tb_fullname.Text = "";
            // 
            // lb_confirmpassword
            // 
            this.lb_confirmpassword.AutoSize = true;
            this.lb_confirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confirmpassword.ForeColor = System.Drawing.Color.White;
            this.lb_confirmpassword.Location = new System.Drawing.Point(12, 272);
            this.lb_confirmpassword.Name = "lb_confirmpassword";
            this.lb_confirmpassword.Size = new System.Drawing.Size(253, 32);
            this.lb_confirmpassword.TabIndex = 9;
            this.lb_confirmpassword.Text = "Confirm Password:";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(261, 110);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(287, 37);
            this.tb_username.TabIndex = 10;
            this.tb_username.Text = "";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(261, 159);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(287, 37);
            this.tb_email.TabIndex = 11;
            this.tb_email.Text = "";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(261, 215);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(287, 37);
            this.tb_password.TabIndex = 12;
            this.tb_password.Text = "";
            // 
            // bt_register
            // 
            this.bt_register.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_register.ForeColor = System.Drawing.Color.White;
            this.bt_register.Location = new System.Drawing.Point(439, 340);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(109, 35);
            this.bt_register.TabIndex = 20;
            this.bt_register.Text = "Register";
            this.bt_register.UseVisualStyleBackColor = false;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // check_errors_timer
            // 
            this.check_errors_timer.Interval = 900;
            this.check_errors_timer.Tick += new System.EventHandler(this.check_errors_timer_Tick);
            // 
            // errorOrsucces_msg
            // 
            this.errorOrsucces_msg.AutoSize = true;
            this.errorOrsucces_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorOrsucces_msg.ForeColor = System.Drawing.Color.Red;
            this.errorOrsucces_msg.Location = new System.Drawing.Point(184, 525);
            this.errorOrsucces_msg.Name = "errorOrsucces_msg";
            this.errorOrsucces_msg.Size = new System.Drawing.Size(0, 25);
            this.errorOrsucces_msg.TabIndex = 22;
            // 
            // tb_confirm_password
            // 
            this.tb_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirm_password.Location = new System.Drawing.Point(261, 272);
            this.tb_confirm_password.Name = "tb_confirm_password";
            this.tb_confirm_password.Size = new System.Drawing.Size(287, 37);
            this.tb_confirm_password.TabIndex = 24;
            this.tb_confirm_password.Text = "";
            // 
            // already_account
            // 
            this.already_account.AutoSize = true;
            this.already_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.already_account.ForeColor = System.Drawing.Color.White;
            this.already_account.Location = new System.Drawing.Point(148, 395);
            this.already_account.Name = "already_account";
            this.already_account.Size = new System.Drawing.Size(281, 25);
            this.already_account.TabIndex = 25;
            this.already_account.Text = "Already have a account? Login";
            this.already_account.Click += new System.EventHandler(this.already_account_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(589, 579);
            this.Controls.Add(this.already_account);
            this.Controls.Add(this.tb_confirm_password);
            this.Controls.Add(this.errorOrsucces_msg);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_confirmpassword);
            this.Controls.Add(this.tb_fullname);
            this.Controls.Add(this.lbreg_password);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_regusername);
            this.Controls.Add(this.lb_fullname);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Label lb_regusername;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lbreg_password;
        private System.Windows.Forms.RichTextBox tb_fullname;
        private System.Windows.Forms.Label lb_confirmpassword;
        private System.Windows.Forms.RichTextBox tb_username;
        private System.Windows.Forms.RichTextBox tb_email;
        private System.Windows.Forms.RichTextBox tb_password;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.Timer check_errors_timer;
        private System.Windows.Forms.Label errorOrsucces_msg;
        private System.Windows.Forms.RichTextBox tb_confirm_password;
        private System.Windows.Forms.Label already_account;
    }
}