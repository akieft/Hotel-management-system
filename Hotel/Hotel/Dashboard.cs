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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerRegistration.Left + 40;
            customerRegistrationuc1.Visible = true;
            customerRegistrationuc1.BringToFront();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            checkOutuc1.Visible = true;
            checkOutuc1.BringToFront();
            MovingPanel.Left = btnCheckout.Left ;
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerDetails.Left + 30;
            customerDetailsuc1.Visible = true;
            customerDetailsuc1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnEmployee.Left;
            employeeuc1.Visible = true;
            employeeuc1.BringToFront();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAddRoom.Left ;
            addRoomuc1.Visible = true;
            addRoomuc1.BringToFront();


        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            addRoomuc1.Visible = false;
            customerRegistrationuc1.Visible = false;
            employeeuc1.Visible = false;
            btnAddRoom.PerformClick();
        }
    }
}
