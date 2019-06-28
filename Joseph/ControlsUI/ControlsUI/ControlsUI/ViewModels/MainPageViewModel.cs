using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ControlsUI.ViewModels
{
	public class MainPageViewModel : BindableBase
	{
		private readonly INavigationService _navigationService;
		public string Title { get; set; } = "say";
		public ICommand NavigateSamplePageCommand => new DelegateCommand(NavigateSamplePage);

		public MainPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
		}
		private async void NavigateSamplePage()
		{
			await _navigationService.NavigateAsync("SamplePage");

		}
	}


}
