using Business.Concrete;
using DataAccess.Concrete.EntityFramwork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormUI
{
    public partial class CustomerAddForm : Form
    {
        public CustomerAddForm()
        {
            InitializeComponent();
        }
        HotelContext db = new HotelContext();
        private void CustomerAddForm_Load(object sender, EventArgs e)
        {
            RoomManager roomManager = new RoomManager(new EfRoomDal());
           
            foreach (var rooms in roomManager.GetAll().Data)
            {
                comboBox1.Items.Add(rooms.RoomName);
            }

            
            dataGridView1.DataSource = db;       
            dataGridView1.DataSource = db.Customers.ToList();



            label8.Visible = false;
         
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var oda1 = db.Customers.Where(c => c.Room == "Oda 1").SingleOrDefault();
            var oda2 = db.Customers.Where(c => c.Room == "Oda 2").SingleOrDefault();
            var oda3 = db.Customers.Where(c => c.Room == "Oda 3").SingleOrDefault();
            var oda4 = db.Customers.Where(c => c.Room == "Oda 4").SingleOrDefault();
            var oda5 = db.Customers.Where(c => c.Room == "Oda 5").SingleOrDefault();
            var oda6 = db.Customers.Where(c => c.Room == "Oda 6").SingleOrDefault();
            var oda7 = db.Customers.Where(c => c.Room == "Oda 7").SingleOrDefault();
            var oda8 = db.Customers.Where(c => c.Room == "Oda 8").SingleOrDefault();
            var oda9 = db.Customers.Where(c => c.Room == "Oda 9").SingleOrDefault();
            var oda10 = db.Customers.Where(c => c.Room == "Oda 10").SingleOrDefault();


            if (Convert.ToString(comboBox1.SelectedItem) == "Oda 1" && oda1!=null)
            {
                MessageBox.Show("Oda 1 Dolu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToString(comboBox1.SelectedItem) == "Oda 2" && oda2 != null)
            {
                MessageBox.Show("Oda 2 Dolu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
            else if (Convert.ToString(comboBox1.SelectedItem) == "Oda 3" && oda3 != null)
            {
                MessageBox.Show("Oda 3 Dolu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToString(comboBox1.SelectedItem) == "Oda 4" && oda4 != null)
            {
                MessageBox.Show("Oda 4 Dolu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToString(comboBox1.SelectedItem) == "Oda 5" && oda5 != null)
            {
                MessageBox.Show("Oda 5 Dolu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToString(comboBox1.SelectedItem) == "Oda 6" && oda6 != null)
            {
                MessageBox.Show("Oda 6 Dolu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToString(comboBox1.SelectedItem) == "Oda 7" && oda7 != null)
            {
                MessageBox.Show("Oda 7 Dolu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToString(comboBox1.SelectedItem) == "Oda 8" && oda8 != null)
            {
                MessageBox.Show("Oda 8 Dolu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToString(comboBox1.SelectedItem) == "Oda 9" && oda9 != null)
            {
                MessageBox.Show("Oda 9 Dolu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToString(comboBox1.SelectedItem) == "Oda 10" && oda10 != null)
            {
                MessageBox.Show("Oda 10 Dolu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }







            else
            {

                CustomerManager customerManager = new CustomerManager(new EfCustomerDal());


                Customer customer = new Customer
                {
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text,
                    Phone = textBox3.Text,
                    StartDate = dateTimePicker1.Text,
                    EndDate = dateTimePicker2.Text,
                    Room = Convert.ToString(comboBox1.SelectedItem)

                };



                customerManager.Add(customer);

                textBox4.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                dataGridView1.DataSource = db;
                dataGridView1.DataSource = db.Customers.ToList();

            }










        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            if (textBox4.Text=="")
            {
                MessageBox.Show("ID Alanı Boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Customer customer = new Customer();

                customer.Id = Convert.ToInt32(textBox4.Text);

                CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

                customerManager.Delete(customer);

                textBox4.Text = "";

                dataGridView1.DataSource = db;
                dataGridView1.DataSource = db.Customers.ToList();
            }
            textBox4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";



        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = db;
            dataGridView1.DataSource = db.Customers.ToList();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("ID Alanı Boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Customer customer = new Customer();

                customer.Id = Convert.ToInt32(textBox4.Text);
                customer.FirstName = textBox1.Text;
                customer.LastName = textBox2.Text;
                customer.Phone = textBox3.Text;
                customer.StartDate = dateTimePicker1.Text;
                customer.EndDate = dateTimePicker2.Text;
                customer.Room = Convert.ToString(comboBox1.SelectedItem);



                CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
                customerManager.Update(customer);

                dataGridView1.DataSource = db;
                dataGridView1.DataSource = db.Customers.ToList();
            }

            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string searchWord = textBox5.Text;

            var results = db.Customers.Where(c => c.FirstName.Contains(searchWord)
            || c.LastName.Contains(searchWord)
            || c.Phone.Contains(searchWord)
             );
            dataGridView1.DataSource = results.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }
    }
}
