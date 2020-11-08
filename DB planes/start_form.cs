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
    public partial class start_form : Form
    {
        private static string CurrentUser;
        private static string CurrentData;

        public static string GetCurrentData()
        {
            return CurrentData;
        }

        public static string GetCurrentUser()
        {
            return CurrentUser;
        }

        public static void ChangeData(string User, string Data)
        {
            CurrentData = Data;
            CurrentUser = User;
        }

        public start_form()
        {
            InitializeComponent();
        }

        private void Sign_In_Button_Click(object sender, EventArgs e)
        {
            Registration_form registration = new Registration_form();
            registration.Show();
        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            Registration_form registration = new Registration_form();
            registration.Show();
            Visible = false;
        }

        private void log_in_button_Click(object sender, EventArgs e)
        {
            log_in_form log_in = new log_in_form();
            log_in.Show();
            Visible = false;
        }

        private void start_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
