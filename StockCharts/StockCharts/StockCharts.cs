using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace StockCharts
{
    public class StockCharts
    {
        [PrimaryKey, AutoIncrement]
        //Info of Note
        public int IDStockCharts { get; set; }
        public string SymbolStockCharts { get; set; }
        public string NoteStockCharts { get; set; }
        public DateTime BeginDateStockCharts { get; set; }
        public DateTime EndDateStockCharts { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", IDStockCharts, SymbolStockCharts,
                NoteStockCharts, BeginDateStockCharts, EndDateStockCharts);
        }

    }
}

