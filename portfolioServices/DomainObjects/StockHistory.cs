using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace portfolioServices.DomainObjects
{
    public class StockHistory
    {
        public string symbol { get; set; }
        public List<BoughtStocks> boughtStocksList { get; set; }
    }

    
}