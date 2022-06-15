using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UnexpectedAppearingOrder
{
    public partial class MyPage2 : ContentPage
    {
        public MyPage2()
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
    }
}

