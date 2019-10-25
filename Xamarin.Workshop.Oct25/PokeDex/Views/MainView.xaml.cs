using PokeDex.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace PokeDex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        private MainViewModel _viewModel;

        public MainView()
            => InitializeComponent();

        protected override void OnBindingContextChanged()
        {
            try
            {
                base.OnBindingContextChanged();
                if (BindingContext != null) _viewModel = (MainViewModel)BindingContext;
            }
            catch { }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var scanView = new ZXingScannerPage();
            scanView.OnScanResult += ScanView_OnScanResult;
            Navigation.PushAsync(scanView);
        }

        private void ScanView_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await Navigation.PopAsync();
                _viewModel.ProcessQRCommand.Execute(result.Text);
            });
        }
    }
}