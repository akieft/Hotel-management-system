
namespace Hotel
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.btnCustomerDetails = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCustomerRegistration = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customerDetailsuc1 = new Hotel.All_User_Control.CustomerDetailsUC();
            this.checkOutuc1 = new Hotel.All_User_Control.CheckOutUC();
            this.customerRegistrationuc1 = new Hotel.All_User_Control.CustomerRegistrationUC();
            this.addRoomuc1 = new Hotel.All_User_Control.AddRoomUC();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.employeeuc1 = new Hotel.All_User_Control.EmployeeUC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MovingPanel);
            this.panel1.Controls.Add(this.btnCustomerDetails);
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCustomerRegistration);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 130);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // MovingPanel
            // 
            this.MovingPanel.BackColor = System.Drawing.Color.White;
            this.MovingPanel.Location = new System.Drawing.Point(52, 93);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(131, 5);
            this.MovingPanel.TabIndex = 17;
            this.MovingPanel.UseWaitCursor = true;
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.BackColor = System.Drawing.Color.White;
            this.btnCustomerDetails.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCustomerDetails.FlatAppearance.BorderSize = 3;
            this.btnCustomerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomerDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnCustomerDetails.Location = new System.Drawing.Point(578, 38);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.Size = new System.Drawing.Size(184, 49);
            this.btnCustomerDetails.TabIndex = 16;
            this.btnCustomerDetails.Text = "Customer Details";
            this.btnCustomerDetails.UseVisualStyleBackColor = false;
            this.btnCustomerDetails.UseWaitCursor = true;
            this.btnCustomerDetails.Click += new System.EventHandler(this.btnCustomerDetails_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.White;
            this.btnCheckout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCheckout.FlatAppearance.BorderSize = 3;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnCheckout.Location = new System.Drawing.Point(423, 38);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(131, 49);
            this.btnCheckout.TabIndex = 15;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.UseWaitCursor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.White;
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmployee.FlatAppearance.BorderSize = 3;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnEmployee.Location = new System.Drawing.Point(780, 38);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(131, 49);
            this.btnEmployee.TabIndex = 14;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.UseWaitCursor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomerRegistration
            // 
            this.btnCustomerRegistration.BackColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.FlatAppearance.BorderSize = 3;
            this.btnCustomerRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerRegistration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCustomerRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnCustomerRegistration.Location = new System.Drawing.Point(202, 38);
            this.btnCustomerRegistration.Name = "btnCustomerRegistration";
            this.btnCustomerRegistration.Size = new System.Drawing.Size(203, 49);
            this.btnCustomerRegistration.TabIndex = 13;
            this.btnCustomerRegistration.Text = "Customer Registration";
            this.btnCustomerRegistration.UseVisualStyleBackColor = false;
            this.btnCustomerRegistration.UseWaitCursor = true;
            this.btnCustomerRegistration.Click += new System.EventHandler(this.btnCustomerRegistration_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.White;
            this.btnAddRoom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddRoom.FlatAppearance.BorderSize = 3;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnAddRoom.Location = new System.Drawing.Point(52, 38);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(131, 49);
            this.btnAddRoom.TabIndex = 12;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.UseWaitCursor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1287, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.UseWaitCursor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1287, 50);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 32);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseWaitCursor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.employeeuc1);
            this.panel2.Controls.Add(this.customerDetailsuc1);
            this.panel2.Controls.Add(this.checkOutuc1);
            this.panel2.Controls.Add(this.customerRegistrationuc1);
            this.panel2.Controls.Add(this.addRoomuc1);
            this.panel2.Location = new System.Drawing.Point(20, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 505);
            this.panel2.TabIndex = 1;
            this.panel2.UseWaitCursor = true;
            // 
            // customerDetailsuc1
            // 
            this.customerDetailsuc1.BackColor = System.Drawing.Color.White;
            this.customerDetailsuc1.Location = new System.Drawing.Point(0, 0);
            this.customerDetailsuc1.Name = "customerDetailsuc1";
            this.customerDetailsuc1.Size = new System.Drawing.Size(1344, 622);
            this.customerDetailsuc1.TabIndex = 3;
            this.customerDetailsuc1.UseWaitCursor = true;
            // 
            // checkOutuc1
            // 
            this.checkOutuc1.BackColor = System.Drawing.Color.White;
            this.checkOutuc1.Location = new System.Drawing.Point(0, 0);
            this.checkOutuc1.Name = "checkOutuc1";
            this.checkOutuc1.Size = new System.Drawing.Size(1344, 622);
            this.checkOutuc1.TabIndex = 2;
            this.checkOutuc1.UseWaitCursor = true;
            // 
            // customerRegistrationuc1
            // 
            this.customerRegistrationuc1.BackColor = System.Drawing.Color.White;
            this.customerRegistrationuc1.Location = new System.Drawing.Point(1, 0);
            this.customerRegistrationuc1.Name = "customerRegistrationuc1";
            this.customerRegistrationuc1.Size = new System.Drawing.Size(1344, 622);
            this.customerRegistrationuc1.TabIndex = 1;
            this.customerRegistrationuc1.UseWaitCursor = true;
            // 
            // addRoomuc1
            // 
            this.addRoomuc1.BackColor = System.Drawing.Color.White;
            this.addRoomuc1.Location = new System.Drawing.Point(1, 0);
            this.addRoomuc1.Name = "addRoomuc1";
            this.addRoomuc1.Size = new System.Drawing.Size(1344, 622);
            this.addRoomuc1.TabIndex = 0;
            this.addRoomuc1.UseWaitCursor = true;
            this.addRoomuc1.Visible = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // employeeuc1
            // 
            this.employeeuc1.BackColor = System.Drawing.Color.White;
            this.employeeuc1.Location = new System.Drawing.Point(0, 0);
            this.employeeuc1.Name = "employeeuc1";
            this.employeeuc1.Size = new System.Drawing.Size(1344, 622);
            this.employeeuc1.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1329, 676);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel MovingPanel;
        private System.Windows.Forms.Button btnCustomerDetails;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCustomerRegistration;
        private System.Windows.Forms.Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.AddRoomUC addRoomuc1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.CustomerRegistrationUC customerRegistrationuc1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.CheckOutUC checkOutuc1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.CustomerDetailsUC customerDetailsuc1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Control.EmployeeUC employeeuc1;
    }
}