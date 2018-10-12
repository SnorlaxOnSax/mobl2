using mobileteam2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
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
			InitializeComponent();
		    ToolbarItems.Add(new ToolbarItem("Home", "home.png", async () =>
		    {
		        Application.Current.MainPage = new NavigationPage(new ItemsPage());

            }));

            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
		    

            var detailNav = new NavigationPage(new ItemDetailPage(viewModel));
		    detailNav.Title = "Timeline";
		    //detailNav.BarBackgroundColor = Color.Accent;
		    detailNav.Icon = "timeline.png";

		    var payNav = new NavigationPage(new PaymentsPage());
		    payNav.Title = "Payments";
            payNav.Icon = "payment.png";
		   // payNav.BarBackgroundColor = Color.White;

		    var photoNav =  new NavigationPage(new PhotosPage());
		    photoNav.Title = "Photos";
            photoNav.Icon = "photos.png";
		    //photoNav.BarBackgroundColor = Color.White;

		    var docNav =  new NavigationPage(new DocumentsPage());
		    docNav.Title = "Documents";
             docNav.Icon = "documents.png";
		    //docNav.BarBackgroundColor = Color.White;
		   
            Children.Add(detailNav);
		    Children.Add(payNav);
		    Children.Add(photoNav);
		    Children.Add(docNav);

        }
    }
}
//androidSpecific:TabbedPage.BarItemColor="#737577"
//androidSpecific:TabbedPage.BarSelectedItemColor="LawnGreen"