using System;
using Microsoft.Maui.Controls;

namespace VeroniqueApp.View
{
    public partial class Page1
    {
        public Page1()
        {
            InitializeComponent();
        }

        async void OnButtonClicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync (new PageGif());
        }
    }
}
