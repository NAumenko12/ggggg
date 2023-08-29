using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App38Example
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InvoicePage : ContentPage
    {
        public InvoicePage()
        {
            var weightEntry = new Entry();
            var amountEntry = new Entry();
            var dateEntry = new Entry();
            var carNumberEntry = new Entry();
            var createButton = new Button { Text = "Create" };

            createButton.Clicked += (sender, args) =>
            {
                var weight = double.Parse(weightEntry.Text);
                var amount = double.Parse(amountEntry.Text);
                var date = DateTime.Parse(dateEntry.Text);
                var carNumber = carNumberEntry.Text;

                var invoice = new Invoice
                {
                    Weight = weight,
                    Amount = amount,
                    Date = date,
                    CarNumber = carNumber
                };
                DisplayAlert("Success", "Invoice created successfully", "OK");
            };

            Content = new StackLayout
            {
                Children = { weightEntry, amountEntry, dateEntry, carNumberEntry, createButton }
            };
        }
    }

    internal class Invoice
    {
        public double Weight { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string CarNumber { get; set; }
    }
}