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

namespace Hotel.All_User_Control
{
    public partial class EmployeeUC : UserControl
    {
        function fn = new function();
        String query;
        public EmployeeUC()
        {
            InitializeComponent();
        }

        private void EmployeeUC_Load(object sender, EventArgs e)
        {
            getMaxId();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtName.Text !="" && txtMobile.Text !="" && txtGender.Text !="" && txtEmail.Text != "" && txtUsername.Text !="" && txtPassword.Text !="")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String username = txtUsername.Text;
                String pass = txtPassword.Text;

                query = "insert into employee (employeeName,mobile,gender,emailID,username,pass) values('"+name+"',"+mobile+",'"+gender+"','"+email+"','"+username+"','"+pass+"')";
                fn.setData(query, "Employee Registered.");

                clearAll();
                getMaxId();
            }
            else
            {
                MessageBox.Show("Fill all Fields.", "Warning...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                setEmployee(dataGridView1);
            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployee(dataGridView2);
            }
        }

        public void getMaxId()
        {
            query = "select max(employeeID) from employee ";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSET.Text = (num + 1).ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Are You Sure?", "Conformation...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where employeeID =" + txtID.Text + " ";
                    fn.setData(query, "Record Deleated.");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }

        }

        private void EmployeeUC_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedItem = -1;
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        public void setEmployee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

      
    }
}
 