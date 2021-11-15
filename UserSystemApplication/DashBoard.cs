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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        private void DashBoard_Load(object sender, EventArgs e)
        {
            lb_fullusername.Text = "Hi," + Login.fn;
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void bt_append_Click(object sender, EventArgs e)
        {

            StreamWriter streamwriter = new StreamWriter("data.txt", append: true);
            streamwriter.WriteLine(console_textnames.Text);
            streamwriter.Close();

        }
    }
}
