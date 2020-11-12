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
using System.Diagnostics;

namespace DB_planes
{
    public partial class My_Tickets_Form : Form
    {
        DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Environment.CurrentDirectory + "\\CourseWork.mdf" + @";Integrated Security = True");
        public My_Tickets_Form()
        {
            InitializeComponent();
        }

        private void My_Tickets_Form_Load(object sender, EventArgs e)
        {
            Table<Sales> sales = db.GetTable<Sales>();
            Table<User> users = db.GetTable<User>();
            Table<Flights> flights = db.GetTable<Flights>();
            var GetUser = from data in users
                          where data.Username == start_form.GetCurrentUser()
                          select data;

            foreach (var data in GetUser)
            {
                if (data.Control_Level < 2)
                {
                    var GetSale = from s in sales
                                  join f in flights on s.Flight_Number equals f.Flight_Number
                                  where s.User_ID == data.User_Id
                                  select new
                                  {
                                      s.Ticket_Number,
                                      s.Plane_Number,
                                      s.Flight_Number,
                                      s.First_Name,
                                      s.Last_Name,
                                      s.Sale_Date,
                                      s.Seat_Type,
                                      s.TakeOff_Date,
                                      s.Sum,
                                      f.TakeOff_City,
                                      f.Landing_City,
                                      f.TakeOff_Time,
                                      f.Landing_Time
                                  };
                    foreach (var dat in GetSale)
                    {
                        dataGridView1.Rows.Add(dat.Ticket_Number, dat.Plane_Number, dat.TakeOff_City + " - " + dat.Landing_City, dat.TakeOff_Time.ToString().Split(' ')[1],
                            dat.Landing_Time.ToString().Split(' ')[1], dat.Flight_Number, data.First_Name + " " + dat.Last_Name, dat.Sale_Date, dat.Seat_Type,
                            dat.TakeOff_Date.ToString().Split(' ')[0], dat.Sum);
                    }
                }
                else
                {
                    var GetSale = from s in sales
                                  join f in flights on s.Flight_Number equals f.Flight_Number
                                  select new
                                  {
                                      s.Ticket_Number,
                                      s.Plane_Number,
                                      s.Flight_Number,
                                      s.First_Name,
                                      s.Last_Name,
                                      s.Sale_Date,
                                      s.Seat_Type,
                                      s.TakeOff_Date,
                                      s.Sum,
                                      f.TakeOff_City,
                                      f.Landing_City,
                                      f.TakeOff_Time,
                                      f.Landing_Time
                                  };
                    foreach (var dat in GetSale)
                    {
                        dataGridView1.Rows.Add(dat.Ticket_Number, dat.Plane_Number, dat.TakeOff_City + " - " + dat.Landing_City, dat.TakeOff_Time.ToString().Split(' ')[1],
                            dat.Landing_Time.ToString().Split(' ')[1], dat.Flight_Number, data.First_Name + " " + dat.Last_Name, dat.Sale_Date, dat.Seat_Type,
                            dat.TakeOff_Date.ToString().Split(' ')[0], dat.Sum);
                    }
                }
            }
        }

        private void My_Tickets_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Table<User> users = db.GetTable<User>();

            var GetUser = from u in users
                          where u.Username == start_form.GetCurrentUser()
                          select u;

            foreach (var data in GetUser)
            {
                if (data.Control_Level > 2)
                {
                    AdminMenu menu = new AdminMenu();
                    menu.Visible = true;
                }
                else
                {
                    Menu_form menu = new Menu_form();
                    menu.Visible = true;
                }
            }
        }
    }
}
