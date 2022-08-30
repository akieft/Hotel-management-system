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
    public partial class CheckOutUC : UserControl
    {
        function fn = new function();
        String query;
        public CheckOutUC()
        {
            InitializeComponent();
        }

        private void CheckOutUC_Load(object sender, EventArgs e)
        {
            query = "select customer.customerID,customer.customerName,customer.mobile,customer.nationality,customer.gender,customer.dateOfBirth,customer.idProof,customer.addres,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomId = rooms.roomId where chekout = 'NO'";
            DataSet ds = fn.getData(query);
            dataGridViewCheckOut.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.customerID,customer.customerName,customer.mobile,customer.nationality,customer.gender,customer.dateOfBirth,customer.idProof,customer.addres,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomId = rooms.roomId where customerName like '" + txtName.Text + "%' and chekout = 'NO'";
            DataSet ds = fn.getData(query);
            dataGridViewCheckOut.DataSource = ds.Tables[0];
        }
        int id;
        private void dataGridViewCheckOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCheckOut.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(dataGridViewCheckOut.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = dataGridViewCheckOut.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomNumber.Text = dataGridViewCheckOut.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if (MessageBox.Show("are you sure?", "Conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtCheckIOutDate.Text;
                    query = "update customer set chekout = 'yes',checkout='" + cdate + "' where customerID =" + id + " update rooms set booked = 'NO' where roomNo ='" + txtRoomNumber.Text + "'";
                    fn.setData(query, "Check out succesfully");
                    CheckOutUC_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("No customer Selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoomNumber.Clear();
            txtCheckIOutDate.ResetText();
        }

        private void CheckOutUC_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
