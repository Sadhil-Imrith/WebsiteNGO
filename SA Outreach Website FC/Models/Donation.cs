using System.ComponentModel.DataAnnotations;

namespace SA_Outreach_Website.Models
{
    public class Donation
    {
        [Required]
        [Key]
        public int DonationId { get; set; }
        public int DonorID { get; set; }
        public decimal Amount { get; set; }

        public DateTime DonationDate { get; set; }
    }
}
