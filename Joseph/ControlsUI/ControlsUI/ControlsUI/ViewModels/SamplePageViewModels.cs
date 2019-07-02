
using Prism.Mvvm;
using Prism.Navigation;

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
