using mobileteam2.Enums;
using Xamarin.Forms;

namespace mobileteam2.Models
{
    public class TimelineItem
    {
        public string Text { get; set; }
        public TimelineSteps Step { get; set; }
        public bool IsNotLastStep { get; set; }
        public FileImageSource Check { get; set; }
    }
}
