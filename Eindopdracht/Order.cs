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

namespace Eindopdracht
{
    class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int PeriodId { get; set; }
        public bool Appetizer { get; set; }
        public bool MainDish { get; set; }
        public bool Dessert { get; set; }
        public Order(int id, int cusomterId, int periodId, bool appetizer, bool mainDish, bool dessert)
        {
            this.Id = id;
            this.CustomerId = cusomterId;
            this.PeriodId = periodId;
            this.Appetizer = appetizer;
            this.MainDish = mainDish;
            this.Dessert = dessert;
        }
    }
}
