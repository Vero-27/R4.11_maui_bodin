using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text.Json;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using VeroniqueApp.ViewModel;

namespace VeroniqueApp.View
{
    public partial class Page2
    {
        private readonly HomePageViewModel _viewModel;

        public Page2()
        {
            InitializeComponent();

            _viewModel = new HomePageViewModel();
            BindingContext = _viewModel;

            _viewModel.GetNextLaunch();
        }

        private void NextLaunchWebcastTap(object sender, TappedEventArgs e)
        {
            OpenUrl(_viewModel.NextLaunch.links.webcast);
        }


        private async void OpenUrl(string link)
        {
            if (string.IsNullOrEmpty(link))
            {
                await DisplayAlert(string.Empty, "This release does not yet have a video.", "Ok");
                return;
            }

            try
            {
                Uri uri = new(link);
                await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Data);

                await DisplayAlert("An unexpected error occured",
                    "No browser may be installed on the device",
                    "Ok");
            }
        }
    }
}