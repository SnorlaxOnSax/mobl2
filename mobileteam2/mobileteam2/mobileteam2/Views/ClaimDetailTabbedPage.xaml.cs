using mobileteam2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
using Application = Xamarin.Forms.Application;
using TabbedPage = Xamarin.Forms.TabbedPage;

namespace mobileteam2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClaimDetailTabbedPage : TabbedPage
	{
		public ClaimDetailTabbedPage (ItemDetailViewModel viewModel)
		{
			InitializeComponent ();
		    ToolbarItems.Add(new ToolbarItem("Home", "icon.png", async () =>
		    {
		       //await Navigation.PopToRootAsync();
		        Application.Current.MainPage = new ItemsPage();


            }));

            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

		    var detailNav = new NavigationPage(new ItemDetailPage(viewModel));
		    detailNav.Title = "Timeline";

		    var payNav = new NavigationPage(new PaymentsPage());
		    payNav.Title = "Payments";
		    //payNav.Icon = "tab_policies.png";
		   // policyNav.BarBackgroundColor = Color.White;

		    var photoNav =  new NavigationPage(new PhotosPage());
		    photoNav.Title = "Photos";
		    //photoNav.Icon = "tab_billing.png";
		    //billingNav.BarBackgroundColor = Color.White;

		    var docNav =  new NavigationPage(new DocumentsPage());
		    docNav.Title = "Documents";
		   // docNav.Icon = "tab_claims.png";
		    //claimsNav.BarBackgroundColor = Color.White;
		   
            Children.Add(detailNav);
		    Children.Add(payNav);
		    Children.Add(photoNav);
		    Children.Add(docNav);

        }
    }
}