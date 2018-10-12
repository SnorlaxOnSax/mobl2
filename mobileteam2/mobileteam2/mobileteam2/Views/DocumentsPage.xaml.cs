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
       // public static void OpenUri(Uri uri);
        private void DownloadEstimate(object sender, EventArgs e)
        {
            EstimateBtn.BackgroundColor = Color.Gray;
            //Device.OpenUri();
        }
        private void DownloadPaymentLetter(object sender, EventArgs e)
        {
            PaymentLetterBtn.BackgroundColor = Color.Gray;
        } 
    }
}