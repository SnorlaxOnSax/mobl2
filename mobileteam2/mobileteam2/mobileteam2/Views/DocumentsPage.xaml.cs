using mobileteam2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobileteam2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DocumentsPage : ContentPage
	{
        public DocumentsPage ()
		{
            InitializeComponent();
		}
        private void DownloadEstimate(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EstimatePage());
        }
        private void DownloadLetter(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LetterPage());
        } 
    }
}