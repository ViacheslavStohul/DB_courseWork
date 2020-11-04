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
    public partial class my_orders_form : Form
    {
        public my_orders_form()
        {
            InitializeComponent();
        }

        private void my_orders_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_form menu = new Menu_form();
            menu.Visible = true;
        }
    }
}
