using System;
using System.Collections.Generic;
using System.Text;

namespace mobileteam2.Models
{
    public enum MenuItemType
    {
      Claims,Photos,Documents,Payments, Settings
        
        
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
