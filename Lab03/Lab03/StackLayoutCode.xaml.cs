using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab03
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayoutCode : ContentPage
    {
        public StackLayoutCode()
        {
            InitializeComponent();
            StackLayout stack = new StackLayout();

            Button button = new Button 
            {
                Text="Stacklayout",
            };

            BoxView boxView = new BoxView
            {
                BackgroundColor = Color.Yellow,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            BoxView boxView2 = new BoxView
            {
                BackgroundColor = Color.Green,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            BoxView boxView3 = new BoxView
            {
                BackgroundColor = Color.Blue,
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 75,
            };

            stack.Children.Add(button);
            stack.Children.Add(boxView);
            stack.Children.Add(boxView2);
            stack.Children.Add (boxView3);

            this.Content = stack;
        }
    }
}