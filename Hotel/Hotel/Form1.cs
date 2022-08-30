using Hotelms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {

        function fn = new function();
        String query;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select username,pass from employee where username = '"+txtUsername.Text+"' and pass ='"+txtPassword.Text+"'";
            DataSet ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count != 0)
            {
                labelError.Visible = false;
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
            }
            else
            {
                  labelError.Visible = true;
                  txtPassword.Clear();
            }

                //  if (txtUsername.Text == "anne" && txtPassword.Text == "anne")
                //  {
                //      labelError.Visible = false;
                //      Dashboard ds = new Dashboard();
                //       this.Hide();
                //       ds.Show();

                //    }
                //   else
                //   {
                //      labelError.Visible = true;
                //      txtPassword.Clear();
                //  }
        }
    }
}
