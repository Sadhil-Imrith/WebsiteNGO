using System.ComponentModel.DataAnnotations;

namespace SA_Outreach_Website.Models
{
    public class Donors
    {
        [Required]
        [Key]
        public int DonorId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
