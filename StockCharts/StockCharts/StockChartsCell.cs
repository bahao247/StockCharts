using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StockCharts
{
    class StockChartsCell: ViewCell
    {
        public StockChartsCell()
        {

            var IDStockChartsLabel = new Label
            {
                TextColor = Color.Blue,
                Font = Font.BoldSystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Start
            };
            IDStockChartsLabel.SetBinding(Label.TextProperty, new Binding("IDStockCharts"));

            var SymbolStockChartsLabel = new Label
            {
                TextColor = Color.Blue,
                Font = Font.BoldSystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Start
            };
            SymbolStockChartsLabel.SetBinding(Label.TextProperty, new Binding("SymbolStockCharts"));

            var NoteStockChartsLabel = new Label
            {
                TextColor = Color.Blue,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            NoteStockChartsLabel.SetBinding(Label.TextProperty, new Binding("NoteStockCharts"));

            var BeginDateStockChartsLabel = new Label
            {
                TextColor = Color.Blue,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            BeginDateStockChartsLabel.SetBinding(Label.TextProperty, new Binding("BeginDateStockCharts", stringFormat: "[{0:dd/MM/yyyy}]"));

            var EndDateStockChartsLabel = new Label
            {
                TextColor = Color.Blue,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            EndDateStockChartsLabel.SetBinding(Label.TextProperty, new Binding("EndDateStockCharts", stringFormat: "[{0:dd/MM/yyyy}]"));

            var panel1 = new StackLayout
            {
                Children = { IDStockChartsLabel, SymbolStockChartsLabel},
                Orientation = StackOrientation.Horizontal

            };

            var panel2 = new StackLayout
            {
                Children = {BeginDateStockChartsLabel, EndDateStockChartsLabel},
                Orientation = StackOrientation.Horizontal
            };

            View = new StackLayout
            {
                Children = {panel1, panel2 },
                Orientation = StackOrientation.Vertical
            };
        }
        
    }
}
