using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace StockCharts
{
    public class StockCell : ViewCell
    {
        public StockCell()
        {
            var IDStockLabel = new Label
            {
                TextColor = Color.Blue,
                Font = Font.BoldSystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Start
            };
            IDStockLabel.SetBinding(Label.TextProperty, new Binding("IDStock"));

            var SymbolStockLabel = new Label
            {
                TextColor = Color.Blue,
                Font = Font.BoldSystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Start
            };
            SymbolStockLabel.SetBinding(Label.TextProperty, new Binding("SymbolStock"));

            var DateStockLabel = new Label
            {
                TextColor = Color.Blue,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            DateStockLabel.SetBinding(Label.TextProperty, new Binding("DateStock", stringFormat: "[{0:dd/MM/yyyy}]"));

            var ValueCloseStockLabel = new Label
            {
                TextColor = Color.Blue,
                Font = Font.BoldSystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Start
            };
            ValueCloseStockLabel.SetBinding(Label.TextProperty, new Binding("ValueCloseStockEntry"));

            var panel1 = new StackLayout
            {
                Children = { IDStockLabel, ValueCloseStockLabel },
                Orientation = StackOrientation.Horizontal

            };

            var panel2 = new StackLayout
            {
                Children = { SymbolStockLabel, DateStockLabel},
                Orientation = StackOrientation.Horizontal
            };

            View = new StackLayout
            {
                Children = { panel1, panel2 },
                Orientation = StackOrientation.Vertical
            };
        }
    }
}
