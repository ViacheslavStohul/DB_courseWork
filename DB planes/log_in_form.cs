using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;

namespace DB_planes
{
    public partial class log_in_form : Form
    {
        public log_in_form()
        {
            InitializeComponent();
        }

        private void back_button_MouseLeave(object sender, EventArgs e)
        {
            back_button.ForeColor = Color.Black;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void log_in_button_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Environment.CurrentDirectory + "\\CourseWork.mdf" + @";Integrated Security = True");
            Table<User> users = db.GetTable<User>();

            var query = (from u in users
                         where u.Username == login_box.Text
                         && u.Password == password_box.Text
                         select u).ToList() ;

            if (query.Count == 0)
                MessageBox.Show("Невірний логін або пароль ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                foreach (var i in query)
                {
                    start_form.ChangeData(i.Username);
                }
                Menu_form menu = new Menu_form();
                menu.Show();
                Visible = false;
            }
        }

        private void back_button_MouseEnter(object sender, EventArgs e)
        {
            back_button.ForeColor = Color.Blue;
        }

        private void log_in_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            start_form log = new start_form();
            log.Visible = true;
        }
    }
}
