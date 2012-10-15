using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace portfolioServices.DomainObjects
{
    public class BoughtStocks
    {
        public DateTime boughtDate { get; set; }
        public int numberOfShares { get; set; }
        public float stockPrice { get; set; }

    }
}