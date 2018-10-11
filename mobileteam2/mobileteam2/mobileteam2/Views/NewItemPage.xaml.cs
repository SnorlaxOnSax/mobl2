using System;
using System.Collections.Generic;
using mobileteam2.Enums;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using mobileteam2.Models;

namespace mobileteam2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {
        public Claim Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Item = new Claim
            {
                Id = Guid.NewGuid().ToString(),
                Status = ClaimStatus.Open,
                Description = "This is an item description."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}