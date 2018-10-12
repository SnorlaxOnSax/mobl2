using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using mobileteam2.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace mobileteam2
{
    public partial class App : Application
    {
        public bool IsDeductiblePaid { get; set; }

        public App()
        {
            IsDeductiblePaid = false;
            InitializeComponent();
            MainPage = new NavigationPage(new ItemsPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
