using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCharts
{
    class Stock
    {
        /*[PrimaryKey, AutoIncrement]*/
        //Info of Stock Charts
        public int IDStock { get; set; }
        public int IDsCharts { get; set; }
        public DateTime DateStock { get; set; }
        public string SymbolStock { get; set; }
        public float ValueCloseStockEntry { get; set; }

        public override string ToString()
        {
            return string.Format("{0}- Symbol = {1} - Date = {2}- Value = {3}", IDStock, SymbolStock,
                DateStock, ValueCloseStockEntry);
        }
    } 
}
