using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Login_form : Form  
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 11)
            {
                MessageBox.Show("Please Write A valid phone Number");
                return;
            }

            if (File.Exists($"{textBox1.Text}")==true)
            {
                StreamReader client_name = new StreamReader($"{textBox1.Text}");
                String CurrentClinet = $"{client_name.ReadLine()}";
                String Booking_Client = CurrentClinet;
                Booking_form Booking = (Booking_form)Application.OpenForms["Booking_form"];

                Booking.Client_Name.Text = $"{Booking_Client}";

                this.Hide();
                Booking.Show();
            }

            else
            {
                MessageBox.Show("Please SignUp First");
                this.Hide();
                Registration_Form register= new Registration_Form();
                register.PhoneNumber.Text = $"{textBox1.Text}";
                register.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Mainform = (Form1)Application.OpenForms["Form1"];
            this.Hide();
            Mainform.Show();
        }
    }
}