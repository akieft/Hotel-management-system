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
    public partial class CustomerDetailsUC : UserControl
    {
        function fn = new function();
        String query;
        public CustomerDetailsUC()
        {
            InitializeComponent();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchBy.SelectedIndex == 0)
            {
                query = "select customer.customerID,customer.customerName,customer.mobile,customer.nationality,customer.gender,customer.dateOfBirth,customer.idProof,customer.addres,customer.checkin,customer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomId = rooms.roomId";
                getRecord(query);
            }
            else if (txtSearchBy.SelectedIndex == 1)
            {
                query = "select customer.customerID,customer.customerName,customer.mobile,customer.nationality,customer.gender,customer.dateOfBirth,customer.idProof,customer.addres,customer.checkin,customer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomId = rooms.roomId where checkout is null";
                getRecord(query);
            }
            else if(txtSearchBy.SelectedIndex == 2)
            {
                query = "select customer.customerID,customer.customerName,customer.mobile,customer.nationality,customer.gender,customer.dateOfBirth,customer.idProof,customer.addres,customer.checkin,customer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomId = rooms.roomId where checkout is not null";
                getRecord(query);
            }
        }

        private void getRecord(String query1)
        {
            DataSet ds = fn.getData(query1);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
