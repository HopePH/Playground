
using Acr.UserDialogs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlsUI.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SamplePage : ContentPage
	{
		public SamplePage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            UserDialogs.Instance.Alert("Button was clicked");
        }
    }
}