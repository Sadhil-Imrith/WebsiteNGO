using System.ComponentModel.DataAnnotations;

namespace SA_Outreach_Website.Models
{
    public class Volunteers
    {
        [Required]
        [Key]
        public int voulunteerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

    }
}
