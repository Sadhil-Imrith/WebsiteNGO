using System.ComponentModel.DataAnnotations;

namespace SA_Outreach_Website.Models
{
    public class Events
    {
        [Required]
        [Key]
        public int EventId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

    }
}