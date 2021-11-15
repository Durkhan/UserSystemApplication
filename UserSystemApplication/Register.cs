using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UserSystemApplication
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
   
        }

        




        private void bt_register_Click(object sender, EventArgs e)
        {
            check_errors_timer.Start();
            string fullname = tb_fullname.Text.Trim();
            string username = tb_username.Text.Trim();
            string email = tb_email.Text.Trim();
            string password = tb_password.Text.Trim();
            string confirm_password = tb_confirm_password.Text.Trim();
            if (String.IsNullOrEmpty(fullname))
                errorOrsucces_msg.Text = "Fullname can't be empty";
            else if (fullname.Length < 10)
                errorOrsucces_msg.Text = "Fullname lentgh can't be less than 10";
            else if (String.IsNullOrEmpty(username))
                errorOrsucces_msg.Text = "Username can't be empty";
            else if (String.IsNullOrEmpty(email))
                errorOrsucces_msg.Text = "Email can't be empty";
            else if (String.IsNullOrEmpty(password))
                errorOrsucces_msg.Text = "Password can't be empty";
            else if (password.Length < 6)
                errorOrsucces_msg.Text = "Password lentgh can't be less than 6";
            else if (String.IsNullOrEmpty(confirm_password))
                errorOrsucces_msg.Text = "Confirm Password can't be empty";
            else if (password != confirm_password)
                errorOrsucces_msg.Text = "Passwords don't match";

            else
            {
                
                errorOrsucces_msg.Text = "Succesfully registered";
                string usersdata = fullname + ":" + username + ":" + email + ":" + password;
                StreamWriter awr = new StreamWriter(Login.users_data, append: true);
                awr.WriteLine(usersdata);
                awr.Close();

            }



        }

        private void check_errors_timer_Tick(object sender, EventArgs e)
        {
            errorOrsucces_msg.Text = "";
        }

        private void already_account_Click(object sender, EventArgs e)
        {
            Login already_account = new Login();
            already_account.Show();
            this.Close();
        }

    }
    }

