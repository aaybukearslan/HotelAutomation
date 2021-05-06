using DataAccess.Concrete.EntityFramwork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace FormUI
{
    public partial class RoomControlForm : Form
    {
        public RoomControlForm()
        {
            InitializeComponent();
        }

        HotelContext db = new HotelContext();

        private void RoomControlForm_Load(object sender, EventArgs e)
        {
         
            
            var oda1 = db.Customers.Where(c => c.Room == "Oda 1").SingleOrDefault();

            if (oda1==null)
            {
                button1.BackColor = Color.Green;
            }
          else if(oda1!=null)
            {
                button1.BackColor = Color.Red;
            }


            var oda2 = db.Customers.Where(c => c.Room == "Oda 2").SingleOrDefault();

            if (oda2 == null)
            {
                button3.BackColor = Color.Green;
            }
            else if (oda2 != null)
            {
                button3.BackColor = Color.Red;
            }

            var oda3 = db.Customers.Where(c => c.Room == "Oda 3").SingleOrDefault();

            if (oda3 == null)
            {
                button2.BackColor = Color.Green;
            }
            else if (oda3 != null)
            {
                button2.BackColor = Color.Red;
            }

            var oda4 = db.Customers.Where(c => c.Room == "Oda 4").SingleOrDefault();

            if (oda4 == null)
            {
                button5.BackColor = Color.Green;
            }
            else if (oda4 != null)
            {
                button5.BackColor = Color.Red;
            }

            var oda5 = db.Customers.Where(c => c.Room == "Oda 5").SingleOrDefault();

            if (oda5 == null)
            {
                button4.BackColor = Color.Green;
            }
            else if (oda5 != null)
            {
                button4.BackColor = Color.Red;
            }


            var oda6 = db.Customers.Where(c => c.Room == "Oda 6").SingleOrDefault();

            if (oda6 == null)
            {
                button10.BackColor = Color.Green;
            }
            else if (oda6 != null)
            {
                button10.BackColor = Color.Red;
            }

            var oda7 = db.Customers.Where(c => c.Room == "Oda 7").SingleOrDefault();

            if (oda7 == null)
            {
                button8.BackColor = Color.Green;
            }
            else if (oda7 != null)
            {
                button8.BackColor = Color.Red;
            }

            var oda8 = db.Customers.Where(c => c.Room == "Oda 8").SingleOrDefault();

            if (oda8 == null)
            {
                button9.BackColor = Color.Green;
            }
            else if (oda8 != null)
            {
                button9.BackColor = Color.Red;
            }

            var oda9 = db.Customers.Where(c => c.Room == "Oda 9").SingleOrDefault();

            if (oda9 == null)
            {
                button6.BackColor = Color.Green;
            }
            else if (oda9 != null)
            {
                button6.BackColor = Color.Red;
            }

            var oda10 = db.Customers.Where(c => c.Room == "Oda 10").SingleOrDefault();

            if (oda10 == null)
            {
                button7.BackColor = Color.Green;
            }
            else if (oda10 != null)
            {
                button7.BackColor = Color.Red;
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        public  void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
