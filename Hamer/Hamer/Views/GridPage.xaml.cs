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
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();
            var grid = new Grid
            {
                RowSpacing = 20,
                ColumnSpacing = 40,
                BackgroundColor = Color.AliceBlue
            };
            var label1 = new Label { Text = "Label 1", BackgroundColor = Color.GreenYellow };
            var label2 = new Label { Text = "Label 2", BackgroundColor = Color.DarkGreen };
            var label3 = new Label { Text = "Label 3", BackgroundColor = Color.Yellow };
            var label4 = new Label { Text = "Label 4", BackgroundColor = Color.Silver };
            grid.Children.Add(label1, 0, 0);
            grid.Children.Add(label2, 0, 1);
            grid.Children.Add(label3, 1, 0);
            grid.Children.Add(label4, 1, 1);
            Grid.SetRowSpan(label1, 2);
            Grid.SetColumnSpan(label2, 2);
            Grid.SetRow(label1, 0);
            Grid.SetColumn(label1, 0);
            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(100, GridUnitType.Absolute)
            });
            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(2, GridUnitType.Star)
            });
            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(1, GridUnitType.Auto)
            });
            Content = grid;
        }
    }
}