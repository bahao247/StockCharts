using Android.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace StockCharts
{
    public partial class HomePage : ContentPage
    {
        private TimeZoneInfo localZone = TimeZoneInfo.Local;

        public HomePage()
        {
            InitializeComponent();

            beginDateStockChartsPicker.Date = DateTime.Now;
            endDateStockChartsPicker.Date = DateTime.Now.AddDays(7);

            addButton.Clicked += addButton_Clicked;

            stockChartsListView.ItemTemplate = new DataTemplate(typeof(StockChartsCell));
            stockChartsListView.ItemSelected += stockChartsListView_ItemSelected; 
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (var data = new DataAccess())
            {
                stockChartsListView.ItemsSource = data.GetStockCharts();
            }
        }

        private void stockChartsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new EditPage((StockCharts)e.SelectedItem));
        }

        private void addButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(symbolStockChartsEntry.Text))
            {
                DisplayAlert("Error", "Symbol of Stock Charts must not be blank", "Accept");
                symbolStockChartsEntry.Focus();
                return;
            }
            
            if (beginDateStockChartsPicker.Date > endDateStockChartsPicker.Date)
            {
                DisplayAlert("Error", "Begin date must <= End date", "Accept");
                beginDateStockChartsPicker.Focus();
                return;
            }

            StockCharts stockcharts = new StockCharts
            {
                SymbolStockCharts = symbolStockChartsEntry.Text,
                NoteStockCharts = noteStockChartsEntry.Text,
                BeginDateStockCharts = beginDateStockChartsPicker.Date.AddHours(localZone.BaseUtcOffset.Hours),
                EndDateStockCharts = endDateStockChartsPicker.Date.AddHours(localZone.BaseUtcOffset.Hours),
            };
            
            using (var data = new DataAccess())
            {
                data.InsertStockCharts(stockcharts);
                stockChartsListView.ItemsSource = data.GetStockCharts();
            }

            symbolStockChartsEntry.Text = string.Empty;
            noteStockChartsEntry.Text = string.Empty;
            beginDateStockChartsPicker.Date = DateTime.Now;
            endDateStockChartsPicker.Date = DateTime.Now;
        }
    }
}
