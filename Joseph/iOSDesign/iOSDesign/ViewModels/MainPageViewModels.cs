using Prism.Mvvm;
using Prism.Navigation;

namespace iOSDesign.ViewModels
{
    public class MainPageViewModels : BindableBase
    {
        private INavigationService _navigationService;

        public MainPageViewModels(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
