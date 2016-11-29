using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace StockCharts
{
    public partial class EditPage : ContentPage
    {
        private StockCharts stockcharts;
        private int statusNoteSwitchPriority;
        private TimeZoneInfo localZone = TimeZoneInfo.Local;
        public EditPage(StockCharts stockcharts)
        {
            InitializeComponent();
            this.stockcharts = stockcharts;

            saveButton.Clicked += SaveButton_Clicked;
            deleteButton.Clicked += DeleteButton_Clicked;

            symbolStockChartsEntry.Text = stockcharts.SymbolStockCharts;
            noteStockChartsEntry.Text = stockcharts.NoteStockCharts;
            beginDateStockChartsPicker.Date = stockcharts.BeginDateStockCharts;
            endDateStockChartsPicker.Date = stockcharts.EndDateStockCharts;

            beginDateStockChartsPicker.Date = stockcharts.BeginDateStockCharts;
            endDateStockChartsPicker.Date = stockcharts.EndDateStockCharts;
        }

        public async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            var rta = await DisplayAlert("Confirm", "Do you want to delete this note?", "Yes", "No");
            if (!rta) return;

            using (var data = new DataAccess())
            {
                data.DeleteStockCharts(stockcharts);
            }

            await DisplayAlert("Confirm", "Note was deleted successfully", "OK");
            await Navigation.PushAsync(new HomePage());
        }

        public async void SaveButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(symbolStockChartsEntry.Text))
            {
                await DisplayAlert("Error", "You must enter names", "Accept");
                symbolStockChartsEntry.Focus();
                return;
            }

            StockCharts stockcharts = new StockCharts
            {
                IDStockCharts = this.stockcharts.IDStockCharts,
                SymbolStockCharts = symbolStockChartsEntry.Text,
                NoteStockCharts = noteStockChartsEntry.Text,
                BeginDateStockCharts = beginDateStockChartsPicker.Date,
                EndDateStockCharts = endDateStockChartsPicker.Date,
            };

            using (var data = new DataAccess())
            {
                data.UpdateStockCharts(stockcharts);
            }
            await DisplayAlert("Confirm", "Content of note updated correctly", "Accept");
            await Navigation.PushAsync(new HomePage());
        }
    }
}
