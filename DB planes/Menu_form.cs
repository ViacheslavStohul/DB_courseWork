using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

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

        private void My_tickets_label_Click(object sender, EventArgs e)
        {
            My_Tickets_Form form = new My_Tickets_Form();
            form.Show();
            Visible = false;
        }

        private void Menu_form_Load(object sender, EventArgs e)
        {
            DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Environment.CurrentDirectory + "\\CourseWork.mdf" + @";Integrated Security = True");
            var query = from u in db.GetTable<User>()
                        where u.Username == start_form.GetCurrentUser()
                        select u;

            foreach(var data in query)
            {
                if (Convert.ToInt32(data.Control_Level) > 2)
                    label2.Visible = true;
            }
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdminMenu menua = new AdminMenu();
            menua.Show();
            Visible = false;
        }
    }
}
