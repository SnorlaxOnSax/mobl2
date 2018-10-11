using System;

using mobileteam2.Models;

namespace mobileteam2.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Claim Item { get; set; }
        public ItemDetailViewModel(Claim item = null)
        {
            Title = item?.Description;
            Item = item;
        }
    }
}
