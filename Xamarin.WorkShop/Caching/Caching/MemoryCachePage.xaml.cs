using Acr.UserDialogs;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Caching
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MemoryCachePage : ContentPage
    {
        public ObservableCollection<MakeUpFake> MakeUps { get; set; }

        public MemoryCachePage()
        {
            InitializeComponent();
            SetData();
        }

        private async void SetData()
        {
            try
            {
                UserDialogs.Instance.ShowLoading("Please wait getting items from the server");
                string apiUri = "https://makeup-api.herokuapp.com/api/v1/products.json";
                var httpClient = new System.Net.Http.HttpClient();
                var _httpResponse = await httpClient.GetAsync(apiUri);
                var json = _httpResponse.Content.ReadAsStringAsync().Result;

                if (!string.IsNullOrEmpty(json))
                {
                    var fakeItems = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Collections.Generic
                        .IEnumerable<MakeUpFake>>(json);
                    MakeUps = new ObservableCollection<MakeUpFake>(fakeItems);
                    listView.ItemsSource = MakeUps;
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
            finally
            {
                UserDialogs.Instance.HideLoading();
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            SetData();
        }
    }
}