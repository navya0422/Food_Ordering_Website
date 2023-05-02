using Food_Ordering_Website;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CloseLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UsernameTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Missing information!");
            }
            else if(UsernameTb.Text=="User" && PassTb.Text == "pass")
            {
                Billing obj = new Billing();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User doesn't exist!");
            }
        }
    }
}
