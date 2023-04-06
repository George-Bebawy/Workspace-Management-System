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
    public partial class Booking_form : Form
    {
        DateTime timenowt1, timenowt2, timenowt3, timenowt4, timenowt5, timenowr1, timenowr2, timenowr3;
        DateTime endtimet1, endtimet2, endtimet3, endtimet4, endtimet5, endtimer1, endtimer2, endtimer3;
      
        public Booking_form()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Booking_form_Load(object sender, EventArgs e)
        {
            Table_1_Drink.Enabled = false;
            Table_2_Drink.Enabled = false;
            Table_3_Drink.Enabled = false;
            Table_4_Drink.Enabled = false;
            Table_5_Drink.Enabled = false;
            Room_1_Drink.Enabled = false;
            Room_2_Drink.Enabled = false;
            Room_3_Drink.Enabled = false;
            //---------------------------
            Bill_Table1.Enabled = false;
            Bill_Table2.Enabled = false;
            Bill_Table3.Enabled = false;
            Bill_Table_4.Enabled = false;
            Bill_Table5.Enabled = false;
            //--------------------------
            Bill_Room1.Enabled = false;
            Bill_Room2.Enabled = false;
            Bill_Room3.Enabled = false;
            //--------------------------
        }
        //Create Bill form to all places that help me to put only one client name in each table or room
        Bill_Form Bill_Table_1 = new Bill_Form();
        Bill_Form Bill_Table_2 = new Bill_Form();
        Bill_Form Bill_Table_3 = new Bill_Form();
        Bill_Form Bill_Table4 = new Bill_Form();
        Bill_Form Bill_Table_5 = new Bill_Form();
        Bill_Form Bill_Room_1 = new Bill_Form();
        Bill_Form Bill_Room_2 = new Bill_Form();
        Bill_Form Bill_Room_3 = new Bill_Form();
        //Create Drink Form for each place
        Drinks Drink_Table_1 = new Drinks();
        Drinks Drink_Table_2 = new Drinks();
        Drinks Drink_Table_3 = new Drinks();
        Drinks Drink_Table_4 = new Drinks();
        Drinks Drink_Table_5 = new Drinks();
        Drinks Drink_Room_1 = new Drinks();
        Drinks Drink_Room_2 = new Drinks();
        Drinks Drink_Room_3 = new Drinks();


        private void button1_Click(object sender, EventArgs e)//Booking Button t1
        {

            if (Table1_Booking.Enabled == true)
            {
                Table1_Booking.Enabled = false;
            }

            //Put ClientName in bill Table1 --> Get Client name from the welcome label
            Bill_Table_1.Client_Name.Text = Client_Name.Text;
            Table_1_Drink.Enabled = true;
            Bill_Table1.Enabled = true;
            timenowt1 = DateTime.Now;
        }
        private void button10_Click(object sender, EventArgs e)//Bill Button Table 1
        { 

           if (Bill_Table1.Enabled == true)
            {
                Table1_Booking.Enabled = true;
            }
           Table_1_Drink.Enabled=false;
          
            //Takeing Time
            endtimet1 = DateTime.Now;
            endtimet1.Subtract(timenowt1);//t1
            
            //Calculate Time
            string s = $"{endtimet1 - timenowt1}";
            int hours  = (s[0]-48)*10+(s[1]-48) ;
            int minutes  = (s[3]-48)*10+(s[4]-48);
            if (minutes > 0) hours++;
            int price = hours*25; //Table Minimum Charge
            Bill_Table_1.Time.Text = $"{price}"; //Add Bill Timing Price To Bill Table1

            string Drink_Price= Drink_Table_1.Total_Price_Value.Text;
            Bill_Table_1.Drinks_Price.Text = Drink_Price;

            double DrinkPrice = 0;
            for(int i=0;i< Drink_Price.Length; i++)
            {
                DrinkPrice += (Drink_Price[i] - 48) * Math.Pow(10, Drink_Price.Length - (i + 1));
            }

            double Total_bill_Price = price + DrinkPrice;
            Bill_Table_1.Total_Price_Value.Text = Convert.ToString(Total_bill_Price);

            this.Hide();
            Bill_Table_1.Show();
            Drink_Table_1.PD = 0;
            Bill_Table1.Enabled = false;
        }
       
        private void button17_Click(object sender, EventArgs e)
        {
            Form1 Mainform = (Form1)Application.OpenForms["Form1"];
            this.Hide();
            Mainform.Show();
        }

        private void Table2_Booking_Click(object sender, EventArgs e)
        {
            if (Table2_Booking.Enabled == true)
            {
                Table2_Booking.Enabled = false;
            }

            Bill_Table_2.Client_Name.Text = Client_Name.Text;
            Table_2_Drink.Enabled = true;
            Bill_Table2.Enabled = true;
            timenowt2 = DateTime.Now;

        }

        private void Table3_Booking_Click(object sender, EventArgs e)
        {
            if (Table3_Booking.Enabled == true)
            {
                Table3_Booking.Enabled = false;
            }
           
            Bill_Table_3.Client_Name.Text = Client_Name.Text;
            Table_3_Drink.Enabled = true;
            Bill_Table3.Enabled = true;
            timenowt3 = DateTime.Now;

        }

        private void Table4_Booking_Click(object sender, EventArgs e)
        {
            if (Table4_Booking.Enabled == true)
            {
                Table4_Booking.Enabled = false;
            }
           
            Bill_Table4.Client_Name.Text = Client_Name.Text;
            Table_4_Drink.Enabled = true;
            Bill_Table_4.Enabled = true;
            timenowt4 = DateTime.Now;

        }

        private void Table5_Booking_Click(object sender, EventArgs e)
        {
            if (Table5_Booking.Enabled == true)
            {
                Table5_Booking.Enabled = false;
            }
          
            Bill_Table_5.Client_Name.Text = Client_Name.Text;
            Table_5_Drink.Enabled = true;
            Bill_Table5.Enabled = true;
            timenowt5 = DateTime.Now;

        }

        private void Room1_Booking_Click(object sender, EventArgs e)
        {
            if (Room1_Booking.Enabled == true)
            {
                Room1_Booking.Enabled = false;
            }
            Bill_Room_1.Client_Name.Text = Client_Name.Text;
            Room_1_Drink.Enabled = true;
            Bill_Room1.Enabled= true;

            timenowr1= DateTime.Now;

        }

        private void Room2_Booking_Click(object sender, EventArgs e)
        {
            if (Room2_Booking.Enabled == true)
            {
                Room2_Booking.Enabled = false;
            }
          
            Bill_Room_2.Client_Name.Text = Client_Name.Text;
            Room_2_Drink.Enabled = true;
            Bill_Room2.Enabled = true;
            timenowr2= DateTime.Now;

        }

        private void Room3_Booking_Click(object sender, EventArgs e)
        {
            if (Room3_Booking.Enabled == true)
            {
                Room3_Booking.Enabled = false;
            }
            
            Bill_Room_3.Client_Name.Text = Client_Name.Text;
            Room_3_Drink.Enabled = true;
            Bill_Room3.Enabled = true;
            timenowr3= DateTime.Now;

        }

        private void Bill_Table2_Click(object sender, EventArgs e)
        {
            if (Bill_Table2.Enabled == true)
            {
                Table2_Booking.Enabled = true;
            }
            Table_2_Drink.Enabled = false;
           

            //Takeing Time
            endtimet2 = DateTime.Now;
            endtimet2.Subtract(timenowt2);//t2

            //Calculate Time
            string s = $"{endtimet2 - timenowt2}";
            int hours = (s[0] - 48) * 10 + (s[1] - 48);
            int minutes = (s[3] - 48) * 10 + (s[4] - 48);
            if (minutes > 0) hours++;
            int price = hours * 25; //Table Minimum Charge
            Bill_Table_2.Time.Text = $"{price}"; //Add Bill Timing Price To Bill Form

            string Drink_Price = Drink_Table_2.Total_Price_Value.Text;
            Bill_Table_2.Drinks_Price.Text = Drink_Table_2.Total_Price_Value.Text;

            double DrinkPrice = 0;
            for (int i = 0; i < Drink_Price.Length; i++)
            {
                DrinkPrice += (Drink_Price[i] - 48) * Math.Pow(10, Drink_Price.Length - (i + 1));
            }

            double Total_bill_Price = price + DrinkPrice;
            Bill_Table_2.Total_Price_Value.Text = Convert.ToString(Total_bill_Price);

            this.Hide();
            Bill_Table_2.Show();
            Drink_Table_2.PD = 0;
            Bill_Table2.Enabled = false;

        }

        private void Bill_Table3_Click(object sender, EventArgs e)
        {
            if (Bill_Table3.Enabled == true)
            {
                Table3_Booking.Enabled = true;
            }
            Table_3_Drink.Enabled = false;

            //Takeing Time
            endtimet3 = DateTime.Now;
            endtimet3.Subtract(timenowt3);//t3

            //Calculate Time
            string s = $"{endtimet3 - timenowt3}";
            int hours = (s[0] - 48) * 10 + (s[1] - 48);
            int minutes = (s[3] - 48) * 10 + (s[4] - 48);
            if (minutes > 0) hours++;
            int price = hours * 25; //Table Minimum Charge
            Bill_Table_3.Time.Text = $"{price}"; //Add Bill Timing Price To Bill Form


            string Drink_Price = Drink_Table_3.Total_Price_Value.Text;
            Bill_Table_3.Drinks_Price.Text = Drink_Table_3.Total_Price_Value.Text;

            double DrinkPrice = 0;
            for (int i = 0; i < Drink_Price.Length; i++)
            {
                DrinkPrice += (Drink_Price[i] - 48) * Math.Pow(10, Drink_Price.Length - (i + 1));
            }

            double Total_bill_Price = price + DrinkPrice;
            Bill_Table_3.Total_Price_Value.Text = Convert.ToString(Total_bill_Price);

            this.Hide();
            Bill_Table_3.Show();
            Drink_Table_3.PD = 0;
            Bill_Table3.Enabled = false;

        }

        private void Bill_Table4_Click(object sender, EventArgs e)
        {
            if (Bill_Table_4.Enabled == true)
            {
                Table4_Booking.Enabled = true;
            }
            Table_4_Drink.Enabled = false;


            //Takeing Time
            endtimet4 = DateTime.Now;
            endtimet4.Subtract(timenowt4);//t4

            //Calculate Time
            string s = $"{endtimet4 - timenowt4}";
            int hours = (s[0] - 48) * 10 + (s[1] - 48);
            int minutes = (s[3] - 48) * 10 + (s[4] - 48);
            if (minutes > 0) hours++;
            int price = hours * 25; //Table Minimum Charge
            Bill_Table4.Time.Text = $"{price}"; //Add Bill Timing Price To Bill Form

            string Drink_Price = Drink_Table_4.Total_Price_Value.Text;
            Bill_Table4.Drinks_Price.Text = Drink_Table_4.Total_Price_Value.Text;

            double DrinkPrice = 0;
            for (int i = 0; i < Drink_Price.Length; i++)
            {
                DrinkPrice += (Drink_Price[i] - 48) * Math.Pow(10, Drink_Price.Length - (i + 1));
            }

            double Total_bill_Price = price + DrinkPrice;
            Bill_Table4.Total_Price_Value.Text = Convert.ToString(Total_bill_Price);

            this.Hide();
            Bill_Table4.Show();
            Drink_Table_4.PD = 0;
            Bill_Table_4.Enabled = false;

        }

        private void Bill_Table5_Click(object sender, EventArgs e)
        {
            if (Bill_Table5.Enabled == true)
            {
                Table5_Booking.Enabled = true;
            }
            Table_5_Drink.Enabled = false;
          
            //Takeing Time
            endtimet5 = DateTime.Now;
            endtimet5.Subtract(timenowt5);//t5

            //Calculate Time
            string s = $"{endtimet5 - timenowt5}";
            int hours = (s[0] - 48) * 10 + (s[1] - 48);
            int minutes = (s[3] - 48) * 10 + (s[4] - 48);
            if (minutes > 0) hours++;
            int price = hours * 25; //Table Minimum Charge
            Bill_Table_5.Time.Text = $"{price}"; //Add Bill Timing Price To Bill Form

            string Drink_Price = Drink_Table_5.Total_Price_Value.Text;
            Bill_Table_5.Drinks_Price.Text = Drink_Table_5.Total_Price_Value.Text;

            double DrinkPrice = 0;
            for (int i = 0; i < Drink_Price.Length; i++)
            {
                DrinkPrice += (Drink_Price[i] - 48) * Math.Pow(10, Drink_Price.Length - (i + 1));
            }

            double Total_bill_Price = price + DrinkPrice;
            Bill_Table_5.Total_Price_Value.Text = Convert.ToString(Total_bill_Price);

            this.Hide();
            Bill_Table_5.Show();
            Drink_Table_5.PD = 0;
            Bill_Table5.Enabled = false;

        }

        private void Bill_Room1_Click(object sender, EventArgs e)
        {
            if (Bill_Room1.Enabled == true)
            {
                Room1_Booking.Enabled = true;
            }
            Room_1_Drink.Enabled = false;
            Bill_Room1.Enabled = true;

      
           
            //Takeing Time
            endtimer1 = DateTime.Now;
            endtimer1.Subtract(timenowr1);//r1

            //Calculate Time
            string s = $"{endtimer1 - timenowr1}";
            int hours = (s[0] - 48) * 10 + (s[1] - 48);
            int minutes = (s[3] - 48) * 10 + (s[4] - 48);
            if (minutes > 0) hours++;
            int price = hours * 50; //Room Minimum Charge
            Bill_Room_1.Time.Text = $"{price}"; //Add Bill Timing Price To Bill Form

            string Drink_Price = Drink_Room_1.Total_Price_Value.Text;
            Bill_Room_1.Drinks_Price.Text = Drink_Room_1.Total_Price_Value.Text;

            double DrinkPrice = 0;
            for (int i = 0; i < Drink_Price.Length; i++)
            {
                DrinkPrice += (Drink_Price[i] - 48) * Math.Pow(10, Drink_Price.Length - (i + 1));
            }

            double Total_bill_Price = price + DrinkPrice;
            Bill_Room_1.Total_Price_Value.Text = Convert.ToString(Total_bill_Price);

            this.Hide();
            Bill_Room_1.Show();
            Drink_Room_1.PD = 0;
            Bill_Room1.Enabled = false;
        }

        private void Bill_Room2_Click(object sender, EventArgs e)
        {
            if (Bill_Room2.Enabled == true)
            {
                Room2_Booking.Enabled = true;
            }
            Room_2_Drink.Enabled = false;
        
           
            //Takeing Time
            endtimer2 = DateTime.Now;
            endtimer2.Subtract(timenowr2);//r2

            //Calculate Time
            string s = $"{endtimer2 - timenowr2}";
            int hours = (s[0] - 48) * 10 + (s[1] - 48);
            int minutes = (s[3] - 48) * 10 + (s[4] - 48);
            if (minutes > 0) hours++;
            int price = hours* 50; //Room Minimum Charge
            Bill_Room_2.Time.Text = $"{price}"; //Add Bill Timing Price To Bill Form

            string Drink_Price = Drink_Room_2.Total_Price_Value.Text;
            Bill_Room_2.Drinks_Price.Text = Drink_Room_2.Total_Price_Value.Text;

            double DrinkPrice = 0;
            for (int i = 0; i < Drink_Price.Length; i++)
            {
                DrinkPrice += (Drink_Price[i] - 48) * Math.Pow(10, Drink_Price.Length - (i + 1));
            }

            double Total_bill_Price = price + DrinkPrice;
            Bill_Room_2.Total_Price_Value.Text = Convert.ToString(Total_bill_Price);

            this.Hide();
            Bill_Room_2.Show();
            Drink_Room_2.PD = 0;
            Bill_Room2.Enabled = false;
        }

        private void Bill_Room3_Click(object sender, EventArgs e)
        {
            if (Bill_Room3.Enabled == true)
            {
                Room3_Booking.Enabled = true;
            }
            Room_3_Drink.Enabled = false;            

            //Takeing Time
            endtimer3 = DateTime.Now;
            endtimer3.Subtract(timenowr3);//r3

            //Calculate Time
            string s = $"{endtimer1 - timenowr1}";
            int hours = (s[0] - 48) * 10 + (s[1] - 48);
            int minutes = (s[3] - 48) * 10 + (s[4] - 48);
            if (minutes > 0) hours++;
            int price = hours * 50; //Room Minimum Charge
            Bill_Room_3.Time.Text = $"{price}"; //Add Bill Timing Price To Bill Form

            string Drink_Price = Drink_Room_3.Total_Price_Value.Text;
            Bill_Room_3.Drinks_Price.Text = Drink_Room_3.Total_Price_Value.Text;

            double DrinkPrice = 0;
            for (int i = 0; i < Drink_Price.Length; i++)
            {
                DrinkPrice += (Drink_Price[i] - 48) * Math.Pow(10, Drink_Price.Length - (i + 1));
            }

            double Total_bill_Price = price + DrinkPrice;
            Bill_Room_3.Total_Price_Value.Text = Convert.ToString(Total_bill_Price);

            this.Hide();
            Bill_Room_3.Show();
            Drink_Room_3.PD = 0;
            Bill_Room3.Enabled = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)//Table 1 Drinks
        {
            this.Hide();
            Drink_Table_1.Show();
        }

        private void Table_2_Drink_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drink_Table_2.Show();
        }

        private void Table_3_Drink_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drink_Table_3.Show();
        }

        private void Table_4_Drink_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drink_Table_4.Show();
        }

        private void Table_5_Drink_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drink_Table_5.Show();
        }

        private void Room_1_Drink_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drink_Room_1.Show();
        }

        private void Room_2_Drink_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drink_Room_2.Show();
        }

        private void Room_3_Drink_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drink_Room_3.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
