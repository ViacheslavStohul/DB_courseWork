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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_form log = new Menu_form();
            log.Visible = true;
        }

        private void UserLabel_MouseEnter(object sender, EventArgs e)
        {
            UserLabel.ForeColor = Color.Blue;
        }

        private void UserLabel_MouseLeave(object sender, EventArgs e)
        {
            UserLabel.ForeColor = Color.Black;
        }

        private void FlightsLabel_MouseEnter(object sender, EventArgs e)
        {
            FlightsLabel.ForeColor = Color.Blue;
        }

        private void FlightsLabel_MouseLeave(object sender, EventArgs e)
        {
            FlightsLabel.ForeColor = Color.Black;
        }

        private void PlanesLabel_MouseEnter(object sender, EventArgs e)
        {
            PlanesLabel.ForeColor = Color.Blue;
        }

        private void PlanesLabel_MouseLeave(object sender, EventArgs e)
        {
            PlanesLabel.ForeColor = Color.Black;
        }

        private void SalesLabel_MouseEnter(object sender, EventArgs e)
        {
            SalesLabel.ForeColor = Color.Blue;
        }

        private void SalesLabel_MouseLeave(object sender, EventArgs e)
        {
            SalesLabel.ForeColor = Color.Black;
        }

        private void UserLabel_Click(object sender, EventArgs e)
        {
            UsersForm users = new UsersForm();
            users.Show();
            Visible = false;
        }

        private void FlightsLabel_Click(object sender, EventArgs e)
        {
            FlightsForm flights = new FlightsForm();
            flights.Show();
            Visible = false;
        }

        private void SalesLabel_Click(object sender, EventArgs e)
        {
            My_Tickets_Form form = new My_Tickets_Form();
            form.Show();
            Visible = false;
        }

        private void PlanesLabel_Click(object sender, EventArgs e)
        {
            LinersForm liners = new LinersForm();
            liners.Show();
            Visible = false;
        }
    }
}
