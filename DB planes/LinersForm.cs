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
    public partial class LinersForm : Form
    {
        DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Environment.CurrentDirectory + "\\CourseWork.mdf" + @";Integrated Security = True");
        public LinersForm()
        {
            InitializeComponent();
        }

        private void LinersForm_Load(object sender, EventArgs e)
        {
            Table<Liners> liners = db.GetTable<Liners>();

            var query = from l in liners
                        select l;

            foreach(var i in query)
            {
                dataGridView1.Rows.Add(i.Board_Number, i.Type, i.Last_check, i.business_places, i.business_cost, i.FirstClass_places,
                    i.FirstClass_cost, i.SecondClass_places, i.SecondClass_cost);
            }
        }

        private void LinersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminMenu menu = new AdminMenu();
            menu.Visible = true;
        }
    }
}
