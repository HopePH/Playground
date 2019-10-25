using Acr.UserDialogs;
using PokeDex.Entities;
using PokeDex.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PropertyChanged;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PokeDex.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        private string[] products = new string[] {
            "https://yolpunlastorage.blob.core.windows.net/yolpunlacontainer/Retail/External/spam1.jpg",
            "https://yolpunlastorage.blob.core.windows.net/yolpunlacontainer/Retail/ChitoGrace/pastillas.png",
            "https://yolpunlastorage.blob.core.windows.net/yolpunlacontainer/Retail/External/napkinion.jpeg",
            "https://yolpunlastorage.blob.core.windows.net/yolpunlacontainer/Retail/ChitoGrace/bigRolls1.png"
        };

        public ICommand TrainerCommand => new DelegateCommand(async () => await GoTrainerView());
        public ICommand ProcessQRCommand => new DelegateCommand<string>(async (s) => await OpenScanner(s));
        public ObservableCollection<Pokemon> PokemonItems { get; set; } = new ObservableCollection<Pokemon>();

        public MainViewModel(INavigationService navigationService)
            => _navigationService = navigationService;

        private async Task GoTrainerView()
            => await _navigationService.NavigateAsync("TrainerDetailView");

        private async Task OpenScanner(string qrCodeResult)
        {
            try
            {
                //try 7, here https://www.the-qrcode-generator.com/?fbclid=IwAR0A6_kwlccWS2LtUrRzCU3Fp7zekX5DNPvhmQkvqMuXkkCz2uOwa5rN2Tg
                var pokemonId = qrCodeResult;

                if (!string.IsNullOrWhiteSpace(pokemonId) && int.TryParse(pokemonId, out int parsedId))
                {
                    DataService dataService = new DataService();
                    var pokemon = await dataService.GetPokemonAsync(parsedId);

                    if (pokemon != null)
                    {
                        pokemon.LovesTianggee = GetItem();
                        PokemonItems.Add(pokemon);
                    }
                }
                else
                    UserDialogs.Instance.Alert("Error in readin QR Code");
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.Alert($"Opps error occured: {ex.Message}");
            }
        }

        private string GetItem()
        {
            Random rnd = new Random();
            int mIndex = rnd.Next(products.Length);
            return products[mIndex];
        }
    }
}
