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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            var loginEntry = new Entry ();
            var passwordEntry = new Entry { IsPassword = true };
            var loginButton = new Button { Text = "Login" };

            loginButton.Clicked += (sender, args) =>
            {
                if (loginEntry.Text == "Otxodoobrazovatel" && passwordEntry.Text == "1234")
                {
                    Navigation.PushAsync(new ManagerPage());
                }
                else if (loginEntry.Text == "Master" && passwordEntry.Text == "123")
                {
                    Navigation.PushAsync(new MasterPage());
                }
                else if (loginEntry.Text== "Otvalshik" && passwordEntry.Text == "000")
                {
                    Navigation.PushAsync(new UserPage());
                }
                else if (loginEntry.Text == "Dispetcher" && passwordEntry.Text == "111")
                {
                    Navigation.PushAsync(new MasterPage());
                }
                else
                {
                    DisplayAlert("Ошибка", "Некорректный логин", "ОК");
                }
            };

            Content = new StackLayout
            {
                Children = { loginEntry, passwordEntry, loginButton }
            };
        }

    }
}