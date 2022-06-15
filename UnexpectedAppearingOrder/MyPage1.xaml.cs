using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UnexpectedAppearingOrder
{
    public partial class MyPage1 : ContentPage
    {
        public MyPage1()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Console.WriteLine("OnAppearing: {0}", this);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Console.WriteLine("OnDisappearing: {0}", this);
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine(" --- Navigating ---");
            await Task.Delay(1000); // for emulator (to position cursor over back button)
            await Navigation.PushAsync(new MyPage2());
        }
    }
}

