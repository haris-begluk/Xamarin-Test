using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hamer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0.5;


            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    this.Padding = new Thickness(0, 20, 0, 0);
                    break;
                case Device.Android:
                case Device.UWP:
                case Device.macOS:
                default:
                    this.Padding = new Thickness(0);
                    break;
            }


            //Padding = Device.OnPlatform(
            //     iOS: new Thickness(0, 20, 0, 0),
            //     Android: new Thickness(20, 20, 20, 20),
            //     WinPhone: new Thickness(20, 0, 20, 20));

            //Device.OnPlatform(iOS: () =>
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //}, Android: () =>
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //});


            //if (Device.RuntimePlatform.Equals(Device.iOS)) //Setting
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //}
            //else if (Device.RuntimePlatform.Equals(Device.Android))
            //{
            //    Padding = new Thickness(20, 20, 20, 20);
            //}
            //else if (Device.RuntimePlatform.Equals(Device.UWP))
            //{
            //    Padding = new Thickness(20, 0, 20, 20);
            //}

        }


    }
}