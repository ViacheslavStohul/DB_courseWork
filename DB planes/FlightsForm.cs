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

            var query = from data in flight
                        select data;
            foreach (var data in query)
            {
                dataGridView1.Rows.Add(data.Flight_Number, data.Plane_Number, data.TakeOff_Date, data.TakeOff_City, data.Landing_Date, data.Landing_City).ToString();
            }
        }
    }
}
