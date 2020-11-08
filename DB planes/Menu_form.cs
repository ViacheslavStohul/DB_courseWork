using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_planes
{
    public partial class Menu_form : Form
    {
        public Menu_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ви впевнені, що хочете вийти з облікового запису?", "Попередження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                start_form start_Form = new start_form();
                start_Form.Visible = true;
                Close();
            }
        }

        private void My_tickets_label_MouseEnter(object sender, EventArgs e)
        {
            My_tickets_label.ForeColor = Color.Blue;
        }


        private void My_tickets_label_MouseLeave(object sender, EventArgs e)
        {
            My_tickets_label.ForeColor = Color.Black;
        }

        private void orderLabel_Click(object sender, EventArgs e)
        {
            tickets_order_form order = new tickets_order_form();
            order.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FlightsForm flights = new FlightsForm();
            flights.Show();
            Visible = false;
        }

        private void orderLabel_MouseEnter(object sender, EventArgs e)
        {
            orderLabel.ForeColor = Color.Blue;
        }

        private void orderLabel_MouseLeave(object sender, EventArgs e)
        {
            orderLabel.ForeColor = Color.Black;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }
    }
}
