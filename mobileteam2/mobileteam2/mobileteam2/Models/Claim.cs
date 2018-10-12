using mobileteam2.Enums;

namespace mobileteam2.Models
{
    public class Claim
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PolicyNumber { get; set; }
        public PolicySymbol Symbol { get; set; }
        public string Number { get; set; }
        public ClaimStatus Status { get; set; }
        public string Description { get; set; }
        public TimelineSteps CurrentStep { get; set; }

        public Claim()
        {
            Description = SetDescriptionBasedOnSymbol(Symbol);
        }

        private static string SetDescriptionBasedOnSymbol(PolicySymbol symbol)
        {
            switch (symbol)
            {
                case PolicySymbol.CA:
                    return "Commercial Auto";
                case PolicySymbol.HO:
                    return "Homeowner's";
                case PolicySymbol.PA:
                    return "Personal Auto";
                default:
                    return string.Empty;
            }
        }
    }
}