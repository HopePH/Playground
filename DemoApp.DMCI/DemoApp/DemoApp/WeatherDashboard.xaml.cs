using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherDashboard : ContentPage
    {
        static string APIKey = "[PLACE YOUR API KEY HERE]";
        static string cityURL = "https://pokeapi.co/api/v2/pokemon/{0}";
        string pokemonId = "7";
        public ObservableCollection<Pokemon> list = new ObservableCollection<Pokemon>();

        public WeatherDashboard()
        {
            InitializeComponent();
            LoadData();
        }

        public async void LoadData()
        {
            var apiUri = string.Format(cityURL, pokemonId);
            var httpClient = new System.Net.Http.HttpClient();
            var httpResponse = await httpClient.GetAsync(apiUri);
            var resultString = httpResponse.Content.ReadAsStringAsync().Result;
            var pokemon = JsonConvert.DeserializeObject<Pokemon>(resultString);
            list.Add(pokemon);
            colPokemons.ItemsSource = list;
        }
    }
}