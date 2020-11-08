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
using System.Net.Http.Headers;

namespace DB_planes
{
    public partial class FlightsForm : Form
    {
        public FlightsForm()
        {
            InitializeComponent();
        }

        private void my_orders_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_form menu = new Menu_form();
            menu.Visible = true;
        }

        private void FlightsForm_Load(object sender, EventArgs e)
        {
            DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Environment.CurrentDirectory + "\\CourseWork.mdf" + @";Integrated Security = True");
            Table<Flights> flight = db.GetTable<Flights>();
            Table<Liners> liners = db.GetTable<Liners>();

            var query = from f in flight
                        join l in liners on f.Plane_Number equals l.Board_Number
                        select new
                        {
                            f.Flight_Number,
                            f.Plane_Number,
                            f.TakeOff_Time,
                            f.TakeOff_City,
                            f.Landing_Time,
                            f.Periodicity,
                            f.Landing_City,
                            l.FirstClass_cost,
                            l.SecondClass_cost,
                            l.business_cost
                        };

            foreach (var data in query)
            {
                dataGridView1.Rows.Add(data.Flight_Number, data.Periodicity, data.business_cost, data.FirstClass_cost, data.SecondClass_cost, data.Plane_Number, data.TakeOff_Time.TimeOfDay,
                    data.TakeOff_City, data.Landing_Time.TimeOfDay, data.Landing_City).ToString();
            }
        }
    }
}
