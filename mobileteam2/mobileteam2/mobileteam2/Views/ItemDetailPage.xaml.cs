using System;
using mobileteam2.Enums;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using mobileteam2.Models;
using mobileteam2.ViewModels;

namespace mobileteam2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();
            var item = new Claim
            {
                Id = Guid.NewGuid().ToString(),
                Status = ClaimStatus.Open,
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        private void OpenPayment(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaymentsPage());
        }

        private void TimelineListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return;
            ((ListView) sender).SelectedItem = null;
        }
    }
}