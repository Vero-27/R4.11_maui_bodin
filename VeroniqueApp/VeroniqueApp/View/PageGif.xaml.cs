using System;
using System.Threading.Tasks;

namespace VeroniqueApp.View
{
    public partial class PageGif
    {
        public PageGif()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing ()
        {
            base.OnAppearing();
            await Task.Delay(100);
            gif.IsAnimationPlaying = true;
        }

    }
}