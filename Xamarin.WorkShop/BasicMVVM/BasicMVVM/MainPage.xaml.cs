using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace BasicMVVM
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
            => GenerateRandomNo();

        private void GenerateRandomNo()
        {
            int resultDouble = RandomNumber(1, 1000000);
            string res = $"My generated no: {resultDouble.ToString()}";
            lblResult.Text = res; 
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
