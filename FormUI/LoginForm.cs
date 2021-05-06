using DataAccess.Concrete.EntityFramwork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
        public static string kulad;

        HotelContext db = new HotelContext();


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            var ee = db.Employees.Where(x => x.UserName == textBox1.Text && x.Password == textBox2.Text).SingleOrDefault();

            if(ee==null)
            {
                MessageBox.Show("Kullanıcı Bulunamadı","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if(ee!=null)
            {
                kulad = textBox1.Text;
                MenuForm menu = new MenuForm();
                
                menu.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
