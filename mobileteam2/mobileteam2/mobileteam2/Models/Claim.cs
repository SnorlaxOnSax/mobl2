using mobileteam2.Enums;

namespace mobileteam2.Models
{
    public class Claim
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public ClaimStatus Status { get; set; }
        public string Description { get; set; }
        public TimelineSteps CurrentStep { get; set; }
    }
}