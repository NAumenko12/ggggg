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
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            var viewInvoiceButton = new Button { Text = "View Invoice" };
            var viewCarNumberButton = new Button { Text = "View Car Number" };

            viewInvoiceButton.Clicked += (sender, args) => Navigation.PushAsync(new InvoicePage());
            viewCarNumberButton.Clicked += (sender, args) => Navigation.PushAsync(new CarNumberPage());

            Content = new StackLayout
            {
                Children = { viewInvoiceButton, viewCarNumberButton }
            };
        }
    }
}