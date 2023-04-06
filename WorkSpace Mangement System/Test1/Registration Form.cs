using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test1
{
     
    public partial class Registration_Form : Form
    {
        string gender;
        public Registration_Form()
        {
            InitializeComponent();
        }
        int day, month, year;
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            if (Client_Name.Text.Length == 0)
            {
                MessageBox.Show("Please Write A valid Name");
                return;
            }
            if (PhoneNumber.Text.Length!=11)
                {
                MessageBox.Show("Please Write A valid phone Number");
                return;
                }
            if (Male.Checked == false && Female.Checked == false)
            {
                MessageBox.Show("Please Select Your Gender");
                return;
            }
            //////////////////////////////////////////////////////////
            if (File.Exists($"{PhoneNumber.Text}") == true)
            {
                MessageBox.Show("You are a Family Member, Lets Login Now");

                Login_form login= new Login_form();
                login.textBox1.Text = $"{PhoneNumber.Text}";
                this.Hide();
                login.Show();
            }
            else
            {
                String Birthday = Convert.ToString(day) + "/" + Convert.ToString(month) + "/" + Convert.ToString(year);
                String[] Register = { Client_Name.Text, PhoneNumber.Text, gender, Birthday };
                File.WriteAllLines($"{PhoneNumber.Text}", Register);
                MessageBox.Show("Regextration is Done");

                Login_form login = new Login_form();
                login.textBox1.Text = $"{PhoneNumber.Text}";
                this.Hide();
                login.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Mainform = (Form1)Application.OpenForms["Form1"];
            this.Hide();
            Mainform.Show();
        }

        private void PhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {
           
            if (Male.Checked==true)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dt = monthCalendar1.SelectionRange.Start;
            day = dt.Day;
            month=dt.Month;
            year=dt.Year;
        }
    }
}