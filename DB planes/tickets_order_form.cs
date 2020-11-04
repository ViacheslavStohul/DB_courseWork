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
    public partial class tickets_order_form : Form
    {
        public tickets_order_form()
        {
            InitializeComponent();
        }

        private void tickets_order_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_form menu = new Menu_form();
            menu.Visible = true;
        }
    }
}
