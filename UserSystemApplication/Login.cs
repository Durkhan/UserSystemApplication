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
    public partial class Login : Form
    {
        public static string users_data = "details.txt";
        public static string fn = "";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (!File.Exists(users_data))
            {
                FileStream file = File.Create(users_data);
                file.Close();
            }

        }

        private void lb_register_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            login_check_errortimer.Start();
            string username_login = tb_username.Text.Trim();
            string password_login = tb_password.Text.Trim();
            string fullname = "";
            string username = "";
            string email = "";
            string password = "";
           



         
            if(String.IsNullOrEmpty(username_login) || String.IsNullOrEmpty(password_login))
            {
                error_login.Text = "Username or Password can't be empty";
            }
            else
            {
                string line = "";

                StreamReader srd = new StreamReader(users_data);
                

                while ((line = srd.ReadLine() )!= null)
                {

                    fullname = line.Split(':')[0];
                    fn = fullname;
                    username = line.Split(':')[1];
                    email = line.Split(':')[2];
                    password = line.Split(':')[3];

                    if(username==username_login && password == password_login)
                    {

                        error_login.Text = "Succesfully signed in";
                        DashBoard dashBoard = new DashBoard();
                        dashBoard.Show();
                        this.Hide();

                    }
                    if (username != username_login || password != password_login)
                    {

                        error_login.Text = "Username or Password is wrong";
                    }
                    }


                }
       
        }

        private void login_check_errortimer_Tick(object sender, EventArgs e)
        {
            error_login.Text = "";
        }
    }
}
