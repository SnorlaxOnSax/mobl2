using System;
using System.Collections.Generic;
using System.Text;

namespace mobileteam2.ViewModels
{
    public class PaymentsViewModel : BaseViewModel
    {
        public object PaymentBtn { get; }

        public PaymentsViewModel()
        {
            Title = "Payments";
        }
    }
}
