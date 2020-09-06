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
            MessageBox.Show("Пароль " + password_box.Text, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
