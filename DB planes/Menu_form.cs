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
    public partial class Menu_form : Form
    {
        public Menu_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ви впевнені, що хочете вийти з облікового запису?", "Попередження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                start_form start_Form = new start_form();
                start_Form.Visible = true;
                Close();
            }
        }
    }
}
