using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eindopdracht
{
    internal class Catering
    {
        public String name { get; set; }
        public List<Period> period { get; set; }
        public List<Customer> customers { get; set; }
        public List<Order> orders { get; set; }

        public Catering()
        {
            this.name = getCompanyName();
            this.period = new List<Period>();
            this.customers = new List<Customer>();
            this.orders = new List<Order>();
        }

        private string getCompanyName()
        {
            string query = @"SELECT name FROM Catering";

            SqlDataReader dr = new SqlCommand(query, Database.openSqlConn()).ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    return dr.GetValue(0).ToString();
                }
            }
            else
            {
                MessageBox.Show("Geen bedrijf gevonden");
            }

            return "";
        }
    }
}