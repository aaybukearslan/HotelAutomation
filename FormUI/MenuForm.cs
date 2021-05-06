using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "admin") {
                EmployeeForm employeeForm = new EmployeeForm();
                employeeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yetkiniz Bulunmamaktadır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerAddForm customerAddForm = new CustomerAddForm();
            customerAddForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RoomControlForm roomControl = new RoomControlForm();
            roomControl.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            label2.Text = LoginForm.kulad ;
            label2.ForeColor = Color.Green;
        }
    }
}
