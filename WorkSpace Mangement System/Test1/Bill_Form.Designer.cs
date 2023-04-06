namespace Test1
{
    partial class Bill_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill_Form));
            this.Table1_Name = new System.Windows.Forms.Label();
            this.Table1_Totaltime = new System.Windows.Forms.Label();
            this.Table1_Drinksprice = new System.Windows.Forms.Label();
            this.Drinks_Price = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Client_Name = new System.Windows.Forms.Label();
            this.check_out = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Total_Price = new System.Windows.Forms.Label();
            this.Total_Price_Value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Table1_Name
            // 
            this.Table1_Name.AutoSize = true;
            this.Table1_Name.BackColor = System.Drawing.Color.Transparent;
            this.Table1_Name.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table1_Name.Location = new System.Drawing.Point(72, 67);
            this.Table1_Name.Name = "Table1_Name";
            this.Table1_Name.Size = new System.Drawing.Size(65, 34);
            this.Table1_Name.TabIndex = 0;
            this.Table1_Name.Text = "Name";
            // 
            // Table1_Totaltime
            // 
            this.Table1_Totaltime.AutoSize = true;
            this.Table1_Totaltime.BackColor = System.Drawing.Color.Transparent;
            this.Table1_Totaltime.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table1_Totaltime.Location = new System.Drawing.Point(72, 129);
            this.Table1_Totaltime.Name = "Table1_Totaltime";
            this.Table1_Totaltime.Size = new System.Drawing.Size(113, 34);
            this.Table1_Totaltime.TabIndex = 2;
            this.Table1_Totaltime.Text = "Total Time ";
            // 
            // Table1_Drinksprice
            // 
            this.Table1_Drinksprice.AutoSize = true;
            this.Table1_Drinksprice.BackColor = System.Drawing.Color.Transparent;
            this.Table1_Drinksprice.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table1_Drinksprice.Location = new System.Drawing.Point(72, 191);
            this.Table1_Drinksprice.Name = "Table1_Drinksprice";
            this.Table1_Drinksprice.Size = new System.Drawing.Size(121, 34);
            this.Table1_Drinksprice.TabIndex = 3;
            this.Table1_Drinksprice.Text = "Drinks Price";
            // 
            // Drinks_Price
            // 
            this.Drinks_Price.AutoSize = true;
            this.Drinks_Price.BackColor = System.Drawing.Color.Transparent;
            this.Drinks_Price.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drinks_Price.Location = new System.Drawing.Point(253, 182);
            this.Drinks_Price.Name = "Drinks_Price";
            this.Drinks_Price.Size = new System.Drawing.Size(30, 34);
            this.Drinks_Price.TabIndex = 7;
            this.Drinks_Price.Text = "...";
            this.Drinks_Price.Click += new System.EventHandler(this.Drinks_Price_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(248, 129);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(39, 34);
            this.Time.TabIndex = 6;
            this.Time.Text = " ....";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // Client_Name
            // 
            this.Client_Name.AutoSize = true;
            this.Client_Name.BackColor = System.Drawing.Color.Transparent;
            this.Client_Name.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_Name.Location = new System.Drawing.Point(248, 67);
            this.Client_Name.Name = "Client_Name";
            this.Client_Name.Size = new System.Drawing.Size(20, 34);
            this.Client_Name.TabIndex = 4;
            this.Client_Name.Text = ".";
            this.Client_Name.Click += new System.EventHandler(this.label4_Click);
            // 
            // check_out
            // 
            this.check_out.BackColor = System.Drawing.Color.Transparent;
            this.check_out.Location = new System.Drawing.Point(327, 374);
            this.check_out.Name = "check_out";
            this.check_out.Size = new System.Drawing.Size(128, 40);
            this.check_out.TabIndex = 8;
            this.check_out.Text = "Check out";
            this.check_out.UseVisualStyleBackColor = false;
            this.check_out.Click += new System.EventHandler(this.check_out_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "-----------------------";
            // 
            // Total_Price
            // 
            this.Total_Price.AutoSize = true;
            this.Total_Price.BackColor = System.Drawing.Color.Transparent;
            this.Total_Price.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Price.Location = new System.Drawing.Point(72, 272);
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.Size = new System.Drawing.Size(108, 34);
            this.Total_Price.TabIndex = 11;
            this.Total_Price.Text = "Total Price";
            // 
            // Total_Price_Value
            // 
            this.Total_Price_Value.AutoSize = true;
            this.Total_Price_Value.BackColor = System.Drawing.Color.Transparent;
            this.Total_Price_Value.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Price_Value.Location = new System.Drawing.Point(248, 272);
            this.Total_Price_Value.Name = "Total_Price_Value";
            this.Total_Price_Value.Size = new System.Drawing.Size(39, 34);
            this.Total_Price_Value.TabIndex = 12;
            this.Total_Price_Value.Text = " ....";
            this.Total_Price_Value.Click += new System.EventHandler(this.Total_Price_Value_Click);
            // 
            // Bill_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Test1.Properties.Resources._5183000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.Total_Price_Value);
            this.Controls.Add(this.Total_Price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_out);
            this.Controls.Add(this.Drinks_Price);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Client_Name);
            this.Controls.Add(this.Table1_Drinksprice);
            this.Controls.Add(this.Table1_Totaltime);
            this.Controls.Add(this.Table1_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bill_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill_Form";
            this.Load += new System.EventHandler(this.Bill_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Table1_Name;
        private System.Windows.Forms.Label Table1_Totaltime;
        private System.Windows.Forms.Label Table1_Drinksprice;
        private System.Windows.Forms.Button check_out;
        public System.Windows.Forms.Label Client_Name;
        public System.Windows.Forms.Label Time;
        public System.Windows.Forms.Label Drinks_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Total_Price;
        public System.Windows.Forms.Label Total_Price_Value;
    }
}