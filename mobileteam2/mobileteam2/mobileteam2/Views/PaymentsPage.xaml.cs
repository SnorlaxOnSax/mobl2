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
	public partial class PaymentsPage : ContentPage
	{
        private PaymentsViewModel paymentPaymentViewModel;
		public PaymentsPage ()
		{
            paymentPaymentViewModel = new PaymentsViewModel();
			InitializeComponent ();

            if (paymentPaymentViewModel.isDeductiblePaid == true)
            {
                PaymentBtn.Text = "Paid";
                Deductible.Text = "•Deductible paid on 10/12/18";
                PaymentBtn.IsEnabled = false;
                PaymentBtn.BackgroundColor = Color.FromHex("#B3B3B3");//LightGrey
            }

            else
            {
                PaymentBtn.IsEnabled = true;
                PaymentBtn.BackgroundColor = Color.FromHex("#2E7D32");//DarkGreen
            }
        }

        private void OpenPayment(object sender, EventArgs e)
        {
            PaymentBtn.Text = "Paid";
            Deductible.Text = "•Deductible paid on 10/12/18";
            PaymentBtn.BackgroundColor = Color.FromHex("#B3B3B3");//LightGrey
            PaymentBtn.IsEnabled = !paymentPaymentViewModel.isDeductiblePaid;
                if (paymentPaymentViewModel.isDeductiblePaid == false)
                 {
                    (Application.Current as App).IsDeductiblePaid = true;
                 }
        }
    }
}