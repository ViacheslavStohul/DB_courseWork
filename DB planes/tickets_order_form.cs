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
                if (Convert.ToInt32(data.Control_Level) >= 1)
                {
                    sum.Text = "0";
                }
            }

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
    }
}
