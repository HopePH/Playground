using Acr.UserDialogs;
using Plugin.Settings;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Caching
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPluginPage : ContentPage
    {
        public SettingsPluginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            CrossSettings.Current.AddOrUpdateValue(key.Text.Trim(), val.Text.Trim());
            UserDialogs.Instance.Alert($"Save {val.Text.Trim()}");
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
            => await Navigation.PopAsync();

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                var valGet = CrossSettings.Current.GetValueOrDefault(key2.Text.Trim(), "");
                UserDialogs.Instance.Alert(valGet);
            }
            catch { }
        }
    }
}