
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
    public partial class AddRoomUC : UserControl
    {
        function fn = new function();
        String query;
        public AddRoomUC()
        {
            InitializeComponent();
        }

        private void AddRoomUC_Load(object sender, EventArgs e)
        {
           query = "select * from rooms";
           DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNumber.Text != "" && txtRoomType.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
            {
                String roomNumber = txtRoomNumber.Text;
                String roomType = txtRoomType.Text;
                String bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into rooms(roomNo,roomType,bed,price) values('" + roomNumber + "','" + roomType + "','" + bed + "'," + price + ")";
                fn.setData(query, "Room Added");

                AddRoomUC_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill All Fields", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txtRoomNumber.Clear();
            txtRoomType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void AddRoomUC_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void AddRoomUC_Enter(object sender, EventArgs e)
        {
            AddRoomUC_Load(this, null);
        }
    }
}
