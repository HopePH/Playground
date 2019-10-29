using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : ContentPage
    {
        private readonly string _userName;
        public DashboardPage(string userName)
        {
            InitializeComponent();
            _userName = userName;
            uText.Text = _userName;
        }
    }
}