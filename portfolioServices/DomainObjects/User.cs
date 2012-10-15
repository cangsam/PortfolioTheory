using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace portfolioServices.DomainObjects
{
    public class User
    {
        public int id { get; set; }
        public int token { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public List<StockHistory> stockHistory;
        public double totalCost;    

    }
}