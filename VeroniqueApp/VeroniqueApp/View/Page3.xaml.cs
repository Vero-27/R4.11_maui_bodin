using VeroniqueApp.ViewModel;

namespace VeroniqueApp.View
{
    public partial class Page3
    {

        public Page3()
        {
            InitializeComponent();
        }

        private void OnEntryTextChanged1(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
            string myText = entry.Text;
        }

        private void OnEntryCompleted1(object? sender, EventArgs eventArgs)
        {
            string? text = ((Entry)sender!)?.Text;
        }


        async void OnButtonClicked1(object? sender, EventArgs eventArgs)
        {
        }

        private async void TakePhoto(object sender, EventArgs e)
        {
            FileResult photo = await MediaPicker.Default.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Select your photo"
            });

            // Here, add the code that is being explained in the next step.
            if (photo != null)
            {
                var stream = await photo.OpenReadAsync();
                myImage.Source = ImageSource.FromStream(() => stream);
            }

        }
    }
}