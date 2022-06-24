using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Eindopdracht
{
    public partial class Form1 : Form
    {
        Catering catering = new Catering();
        public Form1()
        {
            InitializeComponent();

            loadCustomerComboBox();
            loadPeriodComboBox();
        }

        private void CreatePeriod_Click(object sender, EventArgs e)
        {
            DateTime startDate = StartDateInput.Value.Date;
            DateTime endDate = EndDateInput.Value.Date;

            if(startDate < endDate)
            {
                addPeriod(startDate, endDate);
            }
            else
            {
                MessageBox.Show("End date is earlier then start date!");
            }
        }

        private void addPeriod(DateTime StartDateInput, DateTime EndDateInput)
        {
            int nummer = 0;

            string query = @"SELECT MAX(id) FROM Period";

            SqlDataReader dr = new SqlCommand(query, Database.openSqlConn()).ExecuteReader();

            while (dr.Read())
            {
                if (dr.GetValue(0).ToString() != "")
                {
                    nummer += int.Parse(dr.GetValue(0).ToString());
                }
            }

            Period period = new Period(
                nummer++,
                StartDateInput,
                EndDateInput
            );

            catering.period.Add(period);

            string insertQuery = @"INSERT INTO Period (StartDate, EndDate)
                                    VALUES (@StartDateInput, @EndDateInput)";

            SqlCommand cmd = new SqlCommand(insertQuery, Database.openSqlConn());

            cmd.Parameters.AddWithValue("@StartDateInput", StartDateInput);
            cmd.Parameters.AddWithValue("@EndDateInput", EndDateInput);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Created a period");
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            string name = CustomerName.Text.ToString();

            if (!String.IsNullOrEmpty(name))
            {
                addCustomer(name);
            }
            else
            {
                MessageBox.Show("Fill in a name to create a customer!");
            }
        }

        private void addCustomer(string Name)
        {
            int nummer = 0;

            string query = @"SELECT MAX(id) FROM Customer";

            SqlDataReader dr = new SqlCommand(query, Database.openSqlConn()).ExecuteReader();
    
            while (dr.Read())
            {
                if (dr.GetValue(0).ToString() != "")
                {
                    nummer += int.Parse(dr.GetValue(0).ToString());
                }
            }

            Customer customer = new Customer(
                nummer++,
                Name
            );

            catering.customers.Add(customer);

            string insertQuery = @"INSERT INTO Customer (Name) VALUES (@Name)";

            SqlCommand cmd = new SqlCommand(insertQuery, Database.openSqlConn());

            cmd.Parameters.AddWithValue("@Name", Name);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Created a customer");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int periodId = (int)SelectOrderPeriod.SelectedValue;
            int customerId = (int)SelectOrderCustomer.SelectedValue;
            bool appetizer = checkAppetizer.Checked;
            bool mainDish = checkMainDish.Checked;
            bool dessert = checkDessert.Checked;

            addOrder(periodId, customerId, appetizer, mainDish, dessert);
        }

        private void addOrder(int customerId, int periodId, bool appetizer, bool mainDish, bool dessert)
        {
            int nummer = 0;

            string query = @"SELECT MAX(id) FROM [Order]";

            SqlDataReader dr = new SqlCommand(query, Database.openSqlConn()).ExecuteReader();

            while (dr.Read())
            {
                if (dr.GetValue(0).ToString() != "")
                {
                    nummer += int.Parse(dr.GetValue(0).ToString());
                }
            }

            Order order = new Order(
                nummer++,
                customerId,
                periodId,
                appetizer,
                mainDish,
                dessert
            );

            catering.orders.Add(order);

            string insertQuery = @"INSERT INTO [Order] (CustomerId, PeriodId, Appetizer, MainDish, Dessert)
                                    VALUES (@customerId, @periodId, @appetizer, @mainDish, @dessert)";

            SqlCommand cmd = new SqlCommand(insertQuery, Database.openSqlConn());

            cmd.Parameters.AddWithValue("@customerId", customerId);
            cmd.Parameters.AddWithValue("@periodId", periodId);
            cmd.Parameters.AddWithValue("@appetizer", appetizer);
            cmd.Parameters.AddWithValue("@mainDish", mainDish);
            cmd.Parameters.AddWithValue("@dessert", dessert);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Created an order");
        }

        private void loadCustomerComboBox()
        {
            string query = "SELECT * FROM Customer";
            SqlDataAdapter da = new SqlDataAdapter(query, Database.sqlConn());
            Database.openSqlConn();
            DataSet ds = new DataSet();
            da.Fill(ds, "Customers");
            SelectOrderCustomer.DisplayMember = "Name";
            SelectOrderCustomer.ValueMember = "Id";
            SelectOrderCustomer.DataSource = ds.Tables["Customers"];
        }

        private void loadPeriodComboBox()
        {
            string query = "SELECT * FROM Period";
            SqlDataAdapter da = new SqlDataAdapter(query, Database.sqlConn());
            Database.openSqlConn();
            DataSet ds = new DataSet();
            da.Fill(ds, "Periods");
            SelectOrderPeriod.DisplayMember = "StartDate";
            SelectOrderPeriod.ValueMember = "Id";
            SelectOrderPeriod.DataSource = ds.Tables["Periods"];
        }

        private void searchHighest_Click(object sender, EventArgs e)
        {

        }
    }
}
