using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCharts
{
    class Core
    {
        public static async Task<Stock> GetStocks(StockCharts stockcharts)
        {
            string queryString = String.Format(
                "http://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20yahoo.finance.historicaldata%20where%20symbol%20in%20(%22{0}%22)%20and%20startDate%20=%20%27{1:yyyy/MM/dd}%27%20and%20endDate%20=%20%27{2:yyyy/MM/dd}%27&diagnostics=false&format=json&env=store://datatables.org/alltableswithkeys",
                stockcharts.SymbolStockCharts, stockcharts.BeginDateStockCharts.Date, stockcharts.EndDateStockCharts.Date);

            var results = await StockService.getDataFromService(queryString).ConfigureAwait(false);

            int count = (int)results["query"]["count"];
            if (count == 0)
            {
                return null;
            }

            Stock stock = new Stock();
            while (count > 0)
            {
                stock.IDsCharts = stockcharts.IDStockCharts;
                stock.SymbolStock = (string)results["query"]["results"]["quote"][count - 1]["Symbol"];
                stock.ValueCloseStockEntry = (float)results["query"]["results"]["quote"][count - 1]["Close"];
                stock.DateStock = (DateTime)results["query"]["results"]["quote"][count - 1]["Date"];
                
                using (var data = new DataAccess())
                {
                    data.InsertStock(stock);
                }
                --count;
            }
            return stock;
        }
    }
}
