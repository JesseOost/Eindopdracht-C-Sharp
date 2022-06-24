using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht
{
    class Period
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Period(int id, DateTime startDate, DateTime endDate)
        {
            this.Id = id;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}
