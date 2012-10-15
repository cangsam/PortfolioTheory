using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace portfolioServices
{
    public class Stock
    {
        public int id { get; set; }
        public string symbol { get; set; }
        public float price { get; set; }
        public float priceChange { get; set; }
        public float priceChangePercentage { get; set; }
    }
}