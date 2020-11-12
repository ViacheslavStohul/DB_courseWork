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
    public partial class UsersForm : Form
    {
        DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Environment.CurrentDirectory + "\\CourseWork.mdf" + @";Integrated Security = True");
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            Table<User> user = db.GetTable<User>();

            var GetUsers = from u in user
                           select u;

            foreach(var data in GetUsers)
            {
                dataGridView1.Rows.Add(data.User_Id, data.Username, data.Control_Level, data.First_Name,
                    data.Last_Name, data.age);
            }
        }

        private void UsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminMenu menu = new AdminMenu();
            menu.Visible = true;
        }
    }
}
