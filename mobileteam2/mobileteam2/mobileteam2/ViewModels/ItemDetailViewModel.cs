using mobileteam2.Models;

namespace mobileteam2.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Claim Item { get; set; }
        public Timeline Timeline { get; set; }

        public ItemDetailViewModel(Claim item = null)
        {
            Title = "Claim Detail";
            Item = item;
            Timeline = new Timeline(item);
        }
    }
}
