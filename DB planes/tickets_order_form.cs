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
using System.Data.SqlTypes;
using System.CodeDom;

namespace DB_planes
{
    public partial class tickets_order_form : Form
    {
        DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Environment.CurrentDirectory + "\\CourseWork.mdf" + @";Integrated Security = True");

        private void CountSum()
        {
            if (String.IsNullOrEmpty(SeatTypeBox.Text))
                return;

            Table<User> users = db.GetTable<User>();

            sum.Clear();
            sum.Text = SeatTypeBox.Text.Split(' ')[2];
            if (!String.IsNullOrEmpty(age.Text))
            {
                if (Convert.ToInt32(age.Text) < 18)
                    sum.Text = (Convert.ToInt32(sum.Text) * 0.5).ToString();
            }

            var query = from data in users
                        where data.Username == start_form.GetCurrentUser()
                        select data;

            foreach (var data in query)
            {
                if (Convert.ToInt32(data.Control_Level) > 1)
                {
                    sum.Text = "0";
                }
            }

            if (checkBox1.Checked)
                sum.Text = (Convert.ToInt32(sum.Text) * 0.8).ToString();


            sum.Text = (Convert.ToInt32(sum.Text) + Convert.ToInt32(sum.Text)*0.2).ToString();
        }

        public tickets_order_form()
        {
            InitializeComponent();
        }

        private void tickets_order_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_form menu = new Menu_form();
            menu.Visible = true;
        }

        private void tickets_order_form_Load(object sender, EventArgs e)
        {
            Table<Flights> flights = db.GetTable<Flights>();
            Table<User> users = db.GetTable<User>();

            var query = from data in flights
                        orderby data.Flight_Number
                        select data;

            foreach (var data in query)
            {
                comboBox_flight.Items.Add(data.Flight_Number + " " + data.TakeOff_City.Replace(" ", "") + " - " + data.Landing_City.Replace(" ", ""));
            }

            var GetUser = from data in users
                    where data.Username == start_form.GetCurrentUser()
                    select data;

            foreach (var i in GetUser)
            {
                First_Name.Text = i.First_Name;
                Last_Name.Text = i.Last_Name;
                age.Text = i.age.ToString();
            }
        }

        private void comboBox_flight_SelectedIndexChanged(object sender, EventArgs e)
        {
            sum.Clear();
            Table<Flights> flights = db.GetTable<Flights>();
            Table<Liners> liners = db.GetTable<Liners>();

            var query = from f in flights
                        join l in liners on f.Plane_Number equals l.Board_Number
                        where f.Flight_Number == Convert.ToInt32(comboBox_flight.SelectedItem.ToString().Split(' ')[0])
                        select new
                        {
                            l.SecondClass_cost,
                            l.FirstClass_cost,
                            l.business_cost
                        };

            foreach (var data in query)
            {
                SeatTypeBox.Items.Add("Эконом класс " + data.SecondClass_cost + " UAH");
                SeatTypeBox.Items.Add("Первый класс " + data.FirstClass_cost + " UAH");
                SeatTypeBox.Items.Add("Бизнесс класс " + data.business_cost + " UAH");
            }
        }

        private void SeatTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountSum();
        }

        private void age_TextChanged(object sender, EventArgs e)
        {
            CountSum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table<Sales> sales = db.GetTable<Sales>();
            Table<Flights> flights = db.GetTable<Flights>();
            Table<User> users = db.GetTable<User>();

            var GetUser = from data in users
                          where data.Username == start_form.GetCurrentUser()
                          select data;

            var query = from f in flights
                        where f.Flight_Number == Convert.ToInt32(comboBox_flight.SelectedItem.ToString().Split(' ')[0])
                        select f;

            string hours = "0";
            string minutes = "0";
            string seconds = "0";
            string time;
            int plane = 0;

            foreach (var data in query)
            {
                time = data.TakeOff_Time.ToString().Split(' ')[1];
                hours = time.Split(':')[0];
                minutes = time.Split(':')[1];
                seconds = time.Split(':')[2];
                plane = Convert.ToInt32(data.Plane_Number);
            }

            int userID = 0;
            foreach (var data in GetUser)
            {
                userID = data.User_Id;
            }

            DateTime date = monthCalendar1.SelectionStart;
            date.AddHours(Convert.ToDouble(hours));
            date.AddMinutes(Convert.ToDouble(minutes));
            date.AddSeconds(Convert.ToDouble(seconds));
            date.AddMilliseconds(1);

            Sales sale = new Sales
            {
                User_ID = userID,
                Flight_Number = Convert.ToInt32(comboBox_flight.SelectedItem.ToString().Split(' ')[0]),
                Plane_Number = plane,
                First_Name = First_Name.Text,
                Last_Name = Last_Name.Text,
                Sale_Date = DateTime.Now,
                Seat_Type = SeatTypeBox.SelectedItem.ToString().Split(' ')[0] + " " + SeatTypeBox.SelectedItem.ToString().Split(' ')[1],
                TakeOff_Date = date,
                Sum = Convert.ToInt32(sum.Text)
            };

            sales.InsertOnSubmit(sale);
            db.SubmitChanges();
            MessageBox.Show(sale.TakeOff_Date.ToString(), "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CountSum();
        }
    }
}
