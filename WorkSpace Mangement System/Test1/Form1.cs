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

namespace Test1
{
    
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
      
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       
        private void Register_Click(object sender, EventArgs e)
        {
            Registration_Form registration = new Registration_Form() ;
            this.Hide();
            registration.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login_form Login = new Login_form();
            this.Hide();
            Login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Booking_form Booking = (Booking_form)Application.OpenForms["Booking_form"];
            Booking.Client_Name.Text = "Admin";
            this.Hide();
            Booking.Show();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
