using BindingTest.Utility;
using System;
using Xamarin.Forms;

namespace BindingTest
{
    public partial class MainPage : ContentPage
    {
        public object CrossCurrentActivity { get; private set; }
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            Btn_displayToast.Clicked += Button_Clicked;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IDisplayToast>().DisplayToastMessage();
        }
    }
}
