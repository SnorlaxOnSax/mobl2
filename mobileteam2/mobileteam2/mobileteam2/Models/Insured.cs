using mobileteam2.Models.Abstracts;

namespace mobileteam2.Models
{
    public class Insured : PersonBase
    {
        public string ZelleAccountNumber { get; set; }
        public string HomeAddress { get; set; }
    }
}
