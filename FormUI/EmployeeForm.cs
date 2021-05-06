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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        HotelContext db = new HotelContext();
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db;
            dataGridView1.DataSource = db.Employees.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
            Employee employee = new Employee
            {
               
                FirstName = textBox2.Text,
                LastName = textBox3.Text,
                UserName = textBox4.Text,
                Password = textBox5.Text,
                Phone = textBox6.Text,
                BirthDay = dateTimePicker1.Text,
                StartDate = dateTimePicker2.Text,
                Salary = Convert.ToInt32(textBox7.Text),
                DepartmentName = textBox8.Text

            };
            employeeManager.Add(employee);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

            dataGridView1.DataSource = db;
            dataGridView1.DataSource = db.Employees.ToList();

            


        }

        private void button6_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
            Employee employee = new Employee
            {
                Id = Convert.ToInt32(textBox1.Text),
                FirstName = textBox2.Text,
                LastName = textBox3.Text,
                UserName = textBox4.Text,
                Password = textBox5.Text,
                Phone = textBox6.Text,
                BirthDay = dateTimePicker1.Text,
                StartDate = dateTimePicker2.Text,
                Salary = Convert.ToInt32(textBox7.Text),
                DepartmentName = textBox8.Text

            };
            employeeManager.Update(employee);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

            dataGridView1.DataSource = db;
            dataGridView1.DataSource = db.Employees.ToList();

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
            Employee employee = new Employee();
            employee.Id = Convert.ToInt32(textBox1.Text);
            employeeManager.Delete(employee);

            textBox1.Text = "";

            dataGridView1.DataSource = db;
            dataGridView1.DataSource = db.Employees.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox7.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox8.Text= dataGridView1.CurrentRow.Cells[9].Value.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db;
            dataGridView1.DataSource = db.Employees.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string searchWord = textBox9.Text;

            var results = db.Employees.Where(e => e.FirstName.Contains(searchWord)
            || e.LastName.Contains(searchWord)
            || e.Phone.Contains(searchWord)
            || e.DepartmentName.Contains(searchWord)
             );
            dataGridView1.DataSource = results.ToList();
        }
    }
}
