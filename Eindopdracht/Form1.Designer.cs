namespace Eindopdracht
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CreateOrder = new System.Windows.Forms.TabPage();
            this.checkAppetizer = new System.Windows.Forms.CheckBox();
            this.checkMainDish = new System.Windows.Forms.CheckBox();
            this.checkDessert = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectOrderPeriod = new System.Windows.Forms.ComboBox();
            this.SelectOrderCustomer = new System.Windows.Forms.ComboBox();
            this.EndDateInput = new System.Windows.Forms.DateTimePicker();
            this.StartDateInput = new System.Windows.Forms.DateTimePicker();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.CreatePeriod = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Revenue = new System.Windows.Forms.TabPage();
            this.Customers = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPeriod = new System.Windows.Forms.ComboBox();
            this.calculateTotalRevenue = new System.Windows.Forms.Button();
            this.calculateAvarageRevenue = new System.Windows.Forms.Button();
            this.avaragePeriod = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.searchHighest = new System.Windows.Forms.Button();
            this.searchAppNoDes = new System.Windows.Forms.Button();
            this.SearchAbove = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.CreateOrder.SuspendLayout();
            this.Revenue.SuspendLayout();
            this.Customers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CreateOrder);
            this.tabControl1.Controls.Add(this.Revenue);
            this.tabControl1.Controls.Add(this.Customers);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 312);
            this.tabControl1.TabIndex = 0;
            // 
            // CreateOrder
            // 
            this.CreateOrder.Controls.Add(this.checkAppetizer);
            this.CreateOrder.Controls.Add(this.checkMainDish);
            this.CreateOrder.Controls.Add(this.checkDessert);
            this.CreateOrder.Controls.Add(this.label11);
            this.CreateOrder.Controls.Add(this.label10);
            this.CreateOrder.Controls.Add(this.label7);
            this.CreateOrder.Controls.Add(this.label6);
            this.CreateOrder.Controls.Add(this.label5);
            this.CreateOrder.Controls.Add(this.SelectOrderPeriod);
            this.CreateOrder.Controls.Add(this.SelectOrderCustomer);
            this.CreateOrder.Controls.Add(this.EndDateInput);
            this.CreateOrder.Controls.Add(this.StartDateInput);
            this.CreateOrder.Controls.Add(this.CustomerName);
            this.CreateOrder.Controls.Add(this.button2);
            this.CreateOrder.Controls.Add(this.CreateCustomer);
            this.CreateOrder.Controls.Add(this.CreatePeriod);
            this.CreateOrder.Controls.Add(this.label3);
            this.CreateOrder.Controls.Add(this.label2);
            this.CreateOrder.Controls.Add(this.label1);
            this.CreateOrder.Location = new System.Drawing.Point(4, 22);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.CreateOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CreateOrder.Size = new System.Drawing.Size(402, 286);
            this.CreateOrder.TabIndex = 0;
            this.CreateOrder.Text = "Create";
            this.CreateOrder.UseVisualStyleBackColor = true;
            // 
            // checkAppetizer
            // 
            this.checkAppetizer.AutoSize = true;
            this.checkAppetizer.Location = new System.Drawing.Point(290, 150);
            this.checkAppetizer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkAppetizer.Name = "checkAppetizer";
            this.checkAppetizer.Size = new System.Drawing.Size(70, 17);
            this.checkAppetizer.TabIndex = 24;
            this.checkAppetizer.Text = "Appetizer";
            this.checkAppetizer.UseVisualStyleBackColor = true;
            // 
            // checkMainDish
            // 
            this.checkMainDish.AutoSize = true;
            this.checkMainDish.Location = new System.Drawing.Point(290, 171);
            this.checkMainDish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkMainDish.Name = "checkMainDish";
            this.checkMainDish.Size = new System.Drawing.Size(73, 17);
            this.checkMainDish.TabIndex = 23;
            this.checkMainDish.Text = "Main Dish";
            this.checkMainDish.UseVisualStyleBackColor = true;
            // 
            // checkDessert
            // 
            this.checkDessert.AutoSize = true;
            this.checkDessert.Location = new System.Drawing.Point(290, 193);
            this.checkDessert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkDessert.Name = "checkDessert";
            this.checkDessert.Size = new System.Drawing.Size(62, 17);
            this.checkDessert.TabIndex = 22;
            this.checkDessert.Text = "Dessert";
            this.checkDessert.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Customer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Period";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "End date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Start date";
            // 
            // SelectOrderPeriod
            // 
            this.SelectOrderPeriod.FormattingEnabled = true;
            this.SelectOrderPeriod.Location = new System.Drawing.Point(290, 81);
            this.SelectOrderPeriod.Name = "SelectOrderPeriod";
            this.SelectOrderPeriod.Size = new System.Drawing.Size(75, 21);
            this.SelectOrderPeriod.TabIndex = 13;
            // 
            // SelectOrderCustomer
            // 
            this.SelectOrderCustomer.FormattingEnabled = true;
            this.SelectOrderCustomer.Location = new System.Drawing.Point(290, 122);
            this.SelectOrderCustomer.Name = "SelectOrderCustomer";
            this.SelectOrderCustomer.Size = new System.Drawing.Size(75, 21);
            this.SelectOrderCustomer.TabIndex = 12;
            // 
            // EndDateInput
            // 
            this.EndDateInput.Location = new System.Drawing.Point(6, 191);
            this.EndDateInput.Name = "EndDateInput";
            this.EndDateInput.Size = new System.Drawing.Size(137, 20);
            this.EndDateInput.TabIndex = 8;
            // 
            // StartDateInput
            // 
            this.StartDateInput.Location = new System.Drawing.Point(6, 152);
            this.StartDateInput.Name = "StartDateInput";
            this.StartDateInput.Size = new System.Drawing.Size(137, 20);
            this.StartDateInput.TabIndex = 7;
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(161, 191);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 24);
            this.CustomerName.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(161, 221);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(100, 23);
            this.CreateCustomer.TabIndex = 4;
            this.CreateCustomer.Text = "Create";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // CreatePeriod
            // 
            this.CreatePeriod.Location = new System.Drawing.Point(6, 221);
            this.CreatePeriod.Name = "CreatePeriod";
            this.CreatePeriod.Size = new System.Drawing.Size(75, 23);
            this.CreatePeriod.TabIndex = 3;
            this.CreatePeriod.Text = "Create";
            this.CreatePeriod.UseVisualStyleBackColor = true;
            this.CreatePeriod.Click += new System.EventHandler(this.CreatePeriod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Period";
            // 
            // Revenue
            // 
            this.Revenue.Controls.Add(this.calculateAvarageRevenue);
            this.Revenue.Controls.Add(this.avaragePeriod);
            this.Revenue.Controls.Add(this.label8);
            this.Revenue.Controls.Add(this.calculateTotalRevenue);
            this.Revenue.Controls.Add(this.totalPeriod);
            this.Revenue.Controls.Add(this.label4);
            this.Revenue.Location = new System.Drawing.Point(4, 22);
            this.Revenue.Name = "Revenue";
            this.Revenue.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Revenue.Size = new System.Drawing.Size(402, 286);
            this.Revenue.TabIndex = 1;
            this.Revenue.Text = "Revenue";
            this.Revenue.UseVisualStyleBackColor = true;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.SearchAbove);
            this.Customers.Controls.Add(this.searchAppNoDes);
            this.Customers.Controls.Add(this.searchHighest);
            this.Customers.Controls.Add(this.label13);
            this.Customers.Controls.Add(this.label12);
            this.Customers.Controls.Add(this.label9);
            this.Customers.Location = new System.Drawing.Point(4, 22);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(402, 286);
            this.Customers.TabIndex = 2;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Revenue";
            // 
            // totalPeriod
            // 
            this.totalPeriod.FormattingEnabled = true;
            this.totalPeriod.Location = new System.Drawing.Point(6, 35);
            this.totalPeriod.Name = "totalPeriod";
            this.totalPeriod.Size = new System.Drawing.Size(121, 21);
            this.totalPeriod.TabIndex = 1;
            // 
            // calculateTotalRevenue
            // 
            this.calculateTotalRevenue.Location = new System.Drawing.Point(6, 62);
            this.calculateTotalRevenue.Name = "calculateTotalRevenue";
            this.calculateTotalRevenue.Size = new System.Drawing.Size(121, 23);
            this.calculateTotalRevenue.TabIndex = 2;
            this.calculateTotalRevenue.Text = "Calculate";
            this.calculateTotalRevenue.UseVisualStyleBackColor = true;
            // 
            // calculateAvarageRevenue
            // 
            this.calculateAvarageRevenue.Location = new System.Drawing.Point(144, 62);
            this.calculateAvarageRevenue.Name = "calculateAvarageRevenue";
            this.calculateAvarageRevenue.Size = new System.Drawing.Size(121, 23);
            this.calculateAvarageRevenue.TabIndex = 5;
            this.calculateAvarageRevenue.Text = "Calculate";
            this.calculateAvarageRevenue.UseVisualStyleBackColor = true;
            // 
            // avaragePeriod
            // 
            this.avaragePeriod.FormattingEnabled = true;
            this.avaragePeriod.Location = new System.Drawing.Point(144, 35);
            this.avaragePeriod.Name = "avaragePeriod";
            this.avaragePeriod.Size = new System.Drawing.Size(121, 21);
            this.avaragePeriod.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Avarage Revenue";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Highest Paying";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Appetizer no Dessert";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(236, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Above Avarage";
            // 
            // searchHighest
            // 
            this.searchHighest.Location = new System.Drawing.Point(6, 45);
            this.searchHighest.Name = "searchHighest";
            this.searchHighest.Size = new System.Drawing.Size(75, 23);
            this.searchHighest.TabIndex = 3;
            this.searchHighest.Text = "Search";
            this.searchHighest.UseVisualStyleBackColor = true;
            this.searchHighest.Click += new System.EventHandler(this.searchHighest_Click);
            // 
            // searchAppNoDes
            // 
            this.searchAppNoDes.Location = new System.Drawing.Point(108, 45);
            this.searchAppNoDes.Name = "searchAppNoDes";
            this.searchAppNoDes.Size = new System.Drawing.Size(102, 23);
            this.searchAppNoDes.TabIndex = 4;
            this.searchAppNoDes.Text = "Search";
            this.searchAppNoDes.UseVisualStyleBackColor = true;
            // 
            // SearchAbove
            // 
            this.SearchAbove.Location = new System.Drawing.Point(239, 45);
            this.SearchAbove.Name = "SearchAbove";
            this.SearchAbove.Size = new System.Drawing.Size(78, 23);
            this.SearchAbove.TabIndex = 5;
            this.SearchAbove.Text = "Search";
            this.SearchAbove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 336);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.CreateOrder.ResumeLayout(false);
            this.CreateOrder.PerformLayout();
            this.Revenue.ResumeLayout(false);
            this.Revenue.PerformLayout();
            this.Customers.ResumeLayout(false);
            this.Customers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CreateOrder;
        private System.Windows.Forms.TabPage Revenue;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Button CreatePeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker EndDateInput;
        private System.Windows.Forms.DateTimePicker StartDateInput;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.ComboBox SelectOrderPeriod;
        private System.Windows.Forms.ComboBox SelectOrderCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkDessert;
        private System.Windows.Forms.CheckBox checkAppetizer;
        private System.Windows.Forms.CheckBox checkMainDish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateAvarageRevenue;
        private System.Windows.Forms.ComboBox avaragePeriod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button calculateTotalRevenue;
        private System.Windows.Forms.ComboBox totalPeriod;
        private System.Windows.Forms.Button SearchAbove;
        private System.Windows.Forms.Button searchAppNoDes;
        private System.Windows.Forms.Button searchHighest;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
    }
}

