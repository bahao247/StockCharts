using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StockCharts
{
    class StockChartsCellFilterDay: ViewCell
    {
        public StockChartsCellFilterDay()
        {

            var IDstockchartsLabel = new Label
            {
                TextColor = Color.Blue,
                Font = Font.BoldSystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Start
            };
            IDstockchartsLabel.SetBinding(Label.TextProperty, new Binding("IDNote"));

            var NamestockchartsLabel = new Label
            {
                TextColor = Color.Blue,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            NamestockchartsLabel.SetBinding(Label.TextProperty, new Binding("NameNote"));

            var TypestockchartsLabel = new Label
            {
                TextColor = Color.Blue,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            TypestockchartsLabel.SetBinding(Label.TextProperty, new Binding("TypeNote"));

            var DueDateNoteLabel = new Label
            {
                TextColor = Color.Blue,
                Font = Font.BoldSystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Start
            };
            DueDateNoteLabel.SetBinding(Label.TextProperty, new Binding("DueDateNote"));

            var DoneNoteSwitch = new Switch
            {
                HorizontalOptions = LayoutOptions.End
            };
            DoneNoteSwitch.SetBinding(Switch.IsToggledProperty, new Binding("DoneNote"));

            var panel1 = new StackLayout
            {
                Children = { IDstockchartsLabel, DueDateNoteLabel, DoneNoteSwitch },
                Orientation = StackOrientation.Horizontal

            };

            var panel2 = new StackLayout
            {
                Children = { NamestockchartsLabel, TypestockchartsLabel },
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
