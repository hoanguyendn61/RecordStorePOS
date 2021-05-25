using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore.DTO
{
    public class BieuDo
    {
        public DateTime Date { get; set; }
        public double GrossSales { get; set; }
        public double GrossProfit { get; set; }
        //public BieuDo(DateTime date, double gs, double gp)
        //{
        //    this.Date = date;
        //    this.GrossSales = gs;
        //    this.GrossProfit = gp;
        //}
    }
}
