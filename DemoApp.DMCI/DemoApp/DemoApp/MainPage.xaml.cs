using DemoApp.DependencyService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            var userName = entryUsername.Text;
            var password = entryPassword.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Error", "Username or password is emtpy", "Ok");
            }
            else
                await Navigation.PushAsync(new DashboardPage(userName));

            var navStack = Navigation.NavigationStack;
        }

        private void btnJavaCaller_Clicked(object sender, EventArgs e)
        {
            var dependencyService = Xamarin.Forms.DependencyService.Get<IJavaCaller>();
            dependencyService.CallJavaMessageApi();
        }
    }
}
