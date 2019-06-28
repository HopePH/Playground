using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlsUI.ViewModels
{
	public class SamplePageViewModels : BindableBase
	{
		private INavigationService _navigationService;
		public SamplePageViewModels(INavigationService navigationService)
		{
			_navigationService = navigationService;
		}
	}
}
