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
			InitializeComponent ();
		}

        private void DownloadEstimate(object sender, EventArgs e)
        {
            EstimateBtn.BackgroundColor = Color.Gray;
        }
        private void DownloadPaymentLetter(object sender, EventArgs e)
        {
            PaymentLetterBtn.BackgroundColor = Color.Gray;
        } 

    }
}