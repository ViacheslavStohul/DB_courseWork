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
    public partial class Registration_form : Form
    {
        public Registration_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Registration_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            start_form log = new start_form();
            log.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(Username_TextBox.Text) ||
                String.IsNullOrEmpty(Password_TextBox.Text) ||
                String.IsNullOrEmpty(FirstName_TextBox.Text) ||
                String.IsNullOrEmpty(LastName_TextBox.Text))
            {
                MessageBox.Show("Не всі обов'язкові параметри вказані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (Password_TextBox.Text != Password_Repeat_textbox.Text)
            {
                MessageBox.Show("Паролі не співпадають", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password_Repeat_textbox.Clear();
                Password_TextBox.Clear();
            }

            else
            {
                DataContext db = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Environment.CurrentDirectory + "\\CourseWork.mdf" + @";Integrated Security = True");
                Table<User> user = db.GetTable<User>();

                User newUser = new User
                {
                    Username = Username_TextBox.Text,
                    Control_Level = 1,
                    Password = Password_TextBox.Text,
                    First_Name = FirstName_TextBox.Text,
                    Last_Name = LastName_TextBox.Text,
                    age = Convert.ToInt32(Date_of_Birth_TextBox.Text)
                };

                user.InsertOnSubmit(newUser);
                db.SubmitChanges();

                MessageBox.Show("Користувач успішно зареєстрований", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

                //SqlConnection SqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Environment.CurrentDirectory + "\\CourseWork.mdf" + @";Integrated Security = True");
                //SqlCon.Open();
                //SqlCommand addcom = new SqlCommand("INSERT INTO [Users] ([Username], [][Password],[First_Name],[Last_Name],[Age])VALUES(@username,@passsword,@first_name,@last_name,@Age)", SqlCon);
                //addcom.Parameters.AddWithValue("username", Username_TextBox.Text);
                //addcom.Parameters.AddWithValue("passsword", Password_TextBox.Text);
                //addcom.Parameters.AddWithValue("first_name", FirstName_TextBox.Text);
                //addcom.Parameters.AddWithValue("last_name", LastName_TextBox.Text);
                //addcom.Parameters.AddWithValue("Age", Convert.ToInt32(Date_of_Birth_TextBox.Text));
                //addcom.ExecuteNonQuery();
                //SqlCon.Close();
            }
        }

        private void Username_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((e.KeyChar < 'A') || (e.KeyChar > 'z')) && !(Char.IsControl(e.KeyChar)))) e.Handled = true;
        }

        private void Password_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }
    }
}
