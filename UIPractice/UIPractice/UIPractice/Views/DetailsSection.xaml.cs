using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UIPractice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class DetailsSection : ContentView
    {
        int selectedIndex = 0;
        List<Label> tabHeaders = new List<Label>();
        List<VisualElement> tabContents = new List<VisualElement>();
        public DetailsSection()
        {
            InitializeComponent();

            tabHeaders.Add(InfoTab);
            tabHeaders.Add(CastTab);
            tabHeaders.Add(NewsTab);
            tabHeaders.Add(CriticsTab);
            tabHeaders.Add(MediaTab);

            tabContents.Add(InfoContent);
            //tabContents.Add(CastContent);
            //tabContents.Add(NewsContent);
            //tabContents.Add(CriticsContent);
            tabContents.Add(MediaContent);

        }
        private async Task ShowSelection(int newTab)
        {
            if (newTab == selectedIndex) return;

            var selectdTabLabel = tabHeaders[newTab];

            
           
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var tabIndex = tabHeaders.IndexOf((Label)sender);
            await ShowSelection(tabIndex);
        }
    }
}