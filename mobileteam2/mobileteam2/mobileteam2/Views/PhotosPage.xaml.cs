using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mobileteam2.ViewModels;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobileteam2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PhotosPage : ContentPage
	{
	    private PhotoViewModel photoPhotoViewModel;
		public PhotosPage ()
		{
		    photoPhotoViewModel = new PhotoViewModel();
			InitializeComponent ();
		}

	    private async Task TakePhotoClicked(object sender, EventArgs e)
	    {
	       
	        var cameraStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);
	        var storageStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);

	        if (cameraStatus != PermissionStatus.Granted || storageStatus != PermissionStatus.Granted)
	        {
	            var results = await CrossPermissions.Current.RequestPermissionsAsync(new[] { Permission.Camera, Permission.Storage });
	            cameraStatus = results[Permission.Camera];
	            storageStatus = results[Permission.Storage];
	        }

	        if (cameraStatus == PermissionStatus.Granted && storageStatus == PermissionStatus.Granted)
	        {
	            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
	            {
	                Directory = "Sample",
	                Name = "test.jpg",
                    PhotoSize = PhotoSize.Medium,
                    CompressionQuality = 92

	            });
	            photoPhotoViewModel.ImagesTaken.Add(new MyImage{ImagePath = file.Path});
	            ItemsListView.ItemsSource = null;
	            ItemsListView.ItemsSource = photoPhotoViewModel.ImagesTaken;
                
	            
	        }
	        else
	        {
	            await DisplayAlert("Permissions Denied", "Unable to take photos.", "OK");
	           
	        }
        }

	    private void ItemsListView_OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
	        if (e == null) return;
	        ((ListView)sender).SelectedItem = null;	        
        }
	}
}