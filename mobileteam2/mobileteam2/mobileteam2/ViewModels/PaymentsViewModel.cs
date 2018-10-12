using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace mobileteam2.ViewModels
{
   public class PaymentsViewModel :BaseViewModel
    {
        public PaymentsViewModel()
        {
            Title = "Payments";
            var isDeductiblePaid = (Application.Current as App).IsDeductiblePaid;
        }
    }
}
