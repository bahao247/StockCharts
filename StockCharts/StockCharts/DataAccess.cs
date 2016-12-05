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
        private SQLiteConnection connection1;

        public DataAccess()
        {
            var config = DependencyService.Get<IConfig>();
            connection = new SQLiteConnection(config.Platform, Path.Combine(config.DirectoryDB, "StockCharts.db3"));
            connection.CreateTable<StockCharts>();

            connection1 = new SQLiteConnection(config.Platform, Path.Combine(config.DirectoryDB, "StockCharts.db3"));
            connection1.CreateTable<Stock>();
        }

        public void InsertStockCharts(StockCharts stockcharts)
        {
            connection.Insert(stockcharts);
        }

        public void InsertStock(Stock stock)
        {
            connection1.Insert(stock);
        }

        public void UpdateStock(Stock stock)
        {
            connection1.Update(stock);
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

        public Stock GetStock(int IDStock)
        {
            return connection1.Table<Stock>().FirstOrDefault(connection1 => connection1.IDStock == IDStock);
        }

        public List<StockCharts> GetStockCharts()
        {
            return connection.Table<StockCharts>().OrderBy(connection => connection.SymbolStockCharts).ToList();
        }

        public List<Stock> GetStock()
        {
            return connection1.Table<Stock>().OrderBy(connection1 => connection1.SymbolStock).ToList();
        }
        
        public void Dispose()
        {
            connection.Dispose();
            connection1.Dispose();
        }

        public void DeleteStock()
        {
            connection1.DeleteAll<Stock>();
        }
    }
}
