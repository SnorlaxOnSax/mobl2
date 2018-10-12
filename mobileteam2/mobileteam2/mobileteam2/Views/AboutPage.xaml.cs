using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobileteam2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void testclick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DocumentsPage());
            btnPayme.BackgroundColor = Color.Green;
        }
    }
}