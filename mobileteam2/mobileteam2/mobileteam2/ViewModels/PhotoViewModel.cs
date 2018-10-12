using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace mobileteam2.ViewModels
{
    public class PhotoViewModel: BaseViewModel
    {
        public ObservableCollection<MyImage> ImagesTaken { get; set; }
        public PhotoViewModel()
        {
            Title = "Photos";
            ImagesTaken=new ObservableCollection<MyImage>();
        }
    }

    public class MyImage
    {
        public string ImagePath { get; set; }
    }
}
