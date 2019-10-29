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
        static string cityURL = "https://pokeapi.co/api/v2/pokemon/{0}";
        public List<Pokemon> list = new List<Pokemon>();

        public WeatherDashboard()
        {
            InitializeComponent();
        }

        public async Task LoadData(int pokemonid)
        {
            try
            {
                var apiUri = string.Format(cityURL, pokemonid);
                var httpClient = new System.Net.Http.HttpClient();
                var httpResponse = await httpClient.GetAsync(apiUri);
                var resultString = httpResponse.Content.ReadAsStringAsync().Result;
                var pokemon = JsonConvert.DeserializeObject<Pokemon>(resultString);
                list.Add(pokemon);
                if (colPokemons != null) colPokemons.ItemsSource = new ObservableCollection<Pokemon>(list);
            }
            catch (Exception ex)
            { 
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            int pokemonId = int.Parse(ePokemon.Text.Trim());
            await LoadData(pokemonId);
        }
    }
}