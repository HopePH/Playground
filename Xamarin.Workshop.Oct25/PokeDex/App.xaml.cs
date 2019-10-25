using PokeDex.Views;
using Prism;
using Prism.Ioc;
using System;
using Xamarin.Forms;

namespace PokeDex
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            try
            {
                InitializeComponent();
                var rootPage = "http://retail.com/" + $"{nameof(NavigationPage)}/{nameof(MainView)}";
                await NavigationService.NavigateAsync(rootPage);
            }
            catch(Exception ex) 
            { 
                //do nothing
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainView>();
            containerRegistry.RegisterForNavigation<TrainerDetailView>();

            //var unityContainer = containerRegistry.GetContainer();
            //unityContainer.RegisterType<ZXingScannerPage, ZXingScannerPage>(new TransientLifetimeManager(), new InjectionMember[0]);
            //unityContainer.RegisterInstance<IScanner>(new Scanner(), new ContainerControlledLifetimeManager());
        }
    }
}
