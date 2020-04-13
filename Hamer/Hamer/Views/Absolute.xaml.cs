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
    public partial class Absolute : ContentPage
    {
        public Absolute()
        {
            InitializeComponent();
            var layout = new AbsoluteLayout();
            Content = layout;
            var aquaBox = new BoxView { Color = Color.Aqua };
            layout.Children.Add(aquaBox, new Rectangle(0, 0, 1, 1), AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(aquaBox, AbsoluteLayoutFlags.All);
            var redBox = new BoxView { Color = Color.Red };
            layout.Children.Add(redBox, new Rectangle(0.5, 0.1, 100, 100), AbsoluteLayoutFlags.All);
            //AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(redBox, AbsoluteLayoutFlags.PositionProportional);
        }
    }
}