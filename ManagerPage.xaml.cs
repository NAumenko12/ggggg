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
    public partial class ManagerPage : ContentPage
    {
        public ManagerPage()
        {
            var createInvoiceButton = new Button { Text = "Create Invoice" };
            var addCarNumberButton = new Button { Text = "Add Car Number" };

            createInvoiceButton.Clicked += (sender, args) => Navigation.PushAsync(new InvoicePage());
            addCarNumberButton.Clicked += (sender, args) => Navigation.PushAsync(new CarNumberPage());

            Content = new StackLayout
            {
                Children = { createInvoiceButton, addCarNumberButton }
            };
        }
    }
}