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
		public PaymentsPage ()
		{
			InitializeComponent ();
		}

        private void OpenPayment(object sender, EventArgs e)
        {
            PaymentBtn.Text = "Paid";
            Deductible.Text = "•Deductible paid on 10/12/18";
        }
    }
}