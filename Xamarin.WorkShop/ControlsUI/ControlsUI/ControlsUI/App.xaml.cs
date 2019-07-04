using ControlsUI.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlsUI
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer)
		{

		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterForNavigation<SamplePage>();
			containerRegistry.RegisterForNavigation<NavigationPage>();

		}

		protected override void OnInitialized()
		{
			InitializeComponent();
			NavigationService.NavigateAsync("NavigationPage/SamplePage");
		}
	}
}
