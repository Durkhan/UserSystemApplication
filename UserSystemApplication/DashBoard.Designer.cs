
namespace UserSystemApplication
{
    partial class DashBoard
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
            this.bt_logout = new System.Windows.Forms.Button();
            this.lb_fullusername = new System.Windows.Forms.Label();
            this.console_textnames = new System.Windows.Forms.TextBox();
            this.bt_append = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(483, 23);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(105, 24);
            this.bt_logout.TabIndex = 0;
            this.bt_logout.Text = "Log out";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // lb_fullusername
            // 
            this.lb_fullusername.AutoSize = true;
            this.lb_fullusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullusername.ForeColor = System.Drawing.Color.White;
            this.lb_fullusername.Location = new System.Drawing.Point(294, 27);
            this.lb_fullusername.Name = "lb_fullusername";
            this.lb_fullusername.Size = new System.Drawing.Size(70, 20);
            this.lb_fullusername.TabIndex = 1;
            this.lb_fullusername.Text = "Hi,Name";
            // 
            // console_textnames
            // 
            this.console_textnames.Location = new System.Drawing.Point(35, 80);
            this.console_textnames.Multiline = true;
            this.console_textnames.Name = "console_textnames";
            this.console_textnames.Size = new System.Drawing.Size(329, 184);
            this.console_textnames.TabIndex = 2;
            // 
            // bt_append
            // 
            this.bt_append.Location = new System.Drawing.Point(456, 285);
            this.bt_append.Name = "bt_append";
            this.bt_append.Size = new System.Drawing.Size(105, 24);
            this.bt_append.TabIndex = 3;
            this.bt_append.Text = "Append";
            this.bt_append.UseVisualStyleBackColor = true;
            this.bt_append.Click += new System.EventHandler(this.bt_append_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.bt_append);
            this.Controls.Add(this.console_textnames);
            this.Controls.Add(this.lb_fullusername);
            this.Controls.Add(this.bt_logout);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashBoard_FormClosing);
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Label lb_fullusername;
        private System.Windows.Forms.TextBox console_textnames;
        private System.Windows.Forms.Button bt_append;
    }
}