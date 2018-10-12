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
	        //await CrossMedia.Current.Initialize();
         //   var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

	        //if (photo != null)
	        //    PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
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
	                Name = "test.jpg"
	            });
	            photoPhotoViewModel.ImagesTaken.Add(new MyImage{ImagePath = file.Path});
	            ItemsListView.ItemsSource = null;
	            ItemsListView.ItemsSource = photoPhotoViewModel.ImagesTaken;
                
	            //PhotoImage.Source = ImageSource.FromFile(file.Path);
	        }
	        else
	        {
	            await DisplayAlert("Permissions Denied", "Unable to take photos.", "OK");
	            //On iOS you may want to send your user to the settings screen.
	            //CrossPermissions.Current.OpenAppSettings();
	        }
        }
	}
}