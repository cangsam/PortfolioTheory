using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Nancy;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;


namespace portfolioServices
{
    public class MainModule : NancyModule 
    {
        public MainModule() {
            Stock stock = GetStockQuote("goog");
            Get["/stock/{symbol}"] = parameters =>
            {
                stock = GetStockQuote(parameters.symbol);
                return Response.AsJson(stock); //JsonConvert.SerializeObject(GetStockQuote(parameters.symbol));
            };
        }

        private Stock GetStockQuote(string stockSymbol)
        {
            GoogleStock googleStock = new GoogleStock();
            List<GoogleStock> stockArray = new List<GoogleStock>();
            string url = "http://www.google.com/finance/info?infotype=infoquoteall&q=" + stockSymbol;
            WebRequest request = WebRequest.Create(url);
            WebResponse ws = request.GetResponse();
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(GoogleStock));
            try
            {
                String json = new StreamReader(ws.GetResponseStream()).ReadToEnd();
                String jsonWithPrefixSlashesRemoved = json.Substring(3);
                stockArray = JsonConvert.DeserializeObject<List<GoogleStock>>(jsonWithPrefixSlashesRemoved);

            } catch(Exception e)
            {
                string error = e.ToString();
                return null;
            }

            return ConvertGoogleStockToStock(stockArray[0]);
        }

        private Stock ConvertGoogleStockToStock(GoogleStock googleStock)
        {
            Stock stock = new Stock();
            stock.id = 1;
            stock.symbol = googleStock.t;
            stock.price = Convert.ToSingle(googleStock.l_cur);
            stock.priceChange = Convert.ToSingle(googleStock.c);
            stock.priceChangePercentage = Convert.ToSingle(googleStock.cp);

            return stock;
        }
       
    }
}