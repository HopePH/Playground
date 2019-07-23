using SimpleMessage.Utility;
using System;
using Xamarin.Forms;

namespace SimpleMessage
{
	public partial class MainPage : ContentPage
	{
		public object CrossCurrentActivity { get; set; }
		public MainPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			BtnClicked.Clicked += BtnClicked_Clicked;
		}

		private void BtnClicked_Clicked(object sender, EventArgs e)
		{
			DependencyService.Get<IShowUtility>().ShowMessage();
		}
	}
}
