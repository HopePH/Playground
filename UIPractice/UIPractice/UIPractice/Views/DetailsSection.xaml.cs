﻿using System;
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
        int selectionIndex = 0;
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
            tabContents.Add(CastContent);
            tabContents.Add(NewsContent);
            tabContents.Add(CriticsContent);
            tabContents.Add(MediaContent);

        }
        private async Task ShowSelection(int newTab)
        {
            if (newTab == selectionIndex) return;

            var selectedTabLabel = tabHeaders[newTab];
            _ = SelectionUnderline.TranslateTo(selectedTabLabel.Bounds.X, 0, 50, easing: Easing.SinOut);

            var unselectedStyle = (Style)Application.Current.Resources["TabLabel"];
            var selectedStyle = (Style)Application.Current.Resources["SelectedTabLabel"];
            tabHeaders[selectionIndex].Style = unselectedStyle;
            selectedTabLabel.Style = selectedStyle;


            await tabContents[selectionIndex].FadeTo(0);
            tabContents[selectionIndex].IsVisible = false;
            tabContents[newTab].IsVisible = true;
            _ = tabContents[newTab].FadeTo(1);

            selectionIndex = newTab;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var tabIndex = tabHeaders.IndexOf((Label)sender);
            await ShowSelection(tabIndex);
        }
    }
}