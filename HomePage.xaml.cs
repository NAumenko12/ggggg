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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private async void Login(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        private async void SignUp(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrPage());
        }
    }
}