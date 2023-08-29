using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App38Example
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarNumberPage : ContentPage
    {
        public CarNumberPage()
        {
            var carNumbers = GetCarNumbers(); // Получение списка номеров машин

            var listView = new ListView
            {
                ItemsSource = carNumbers,
                ItemTemplate = new DataTemplate(() =>
                {
                    var nameLabel = new Label();
                    nameLabel.SetBinding(Label.TextProperty, "Number");

                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Children = { nameLabel }
                        }
                    };
                })
            };

            Content = new StackLayout
            {
                Children = { listView }
            };
        }

        public View listView { get; private set; }
    }
}