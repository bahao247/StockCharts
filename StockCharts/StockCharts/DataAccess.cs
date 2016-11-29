using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;
using System.IO;

namespace StockCharts
{
    class DataAccess : IDisposable
    {
        private SQLiteConnection connection;

        public DataAccess()
        {
            var config = DependencyService.Get<IConfig>();
            connection = new SQLiteConnection(config.Platform, Path.Combine(config.DirectoryDB, "StockCharts.db3"));
            connection.CreateTable<StockCharts>();
        }

        public void InsertStockCharts(StockCharts stockcharts)
        {
            connection.Insert(stockcharts);
        }

        public void UpdateStockCharts(StockCharts stockcharts)
        {
            connection.Update(stockcharts);
        }

        public void DeleteStockCharts(StockCharts stockcharts)
        {
            connection.Delete(stockcharts);
        }

        public StockCharts GetStockCharts(int IDStockCharts)
        {
            return connection.Table<StockCharts>().FirstOrDefault(connection => connection.IDStockCharts == IDStockCharts);
        }

        public List<StockCharts> GetStockCharts()
        {
            return connection.Table<StockCharts>().OrderBy(connection => connection.SymbolStockCharts).ToList();
        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
