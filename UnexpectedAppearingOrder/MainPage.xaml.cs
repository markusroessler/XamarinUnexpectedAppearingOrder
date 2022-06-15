using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UnexpectedAppearingOrder
{
    public partial class MainPage : NavigationPage
    {
        public MainPage() : base(new MyPage1())
        {
            InitializeComponent();
        }
    }
}

