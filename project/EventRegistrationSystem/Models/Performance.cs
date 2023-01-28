using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models
{
    public class Performance
    {
        public int Id { get; set; }

        [Display(Name = "Place in queue")]
        [Required]
        [Range(1, int.MaxValue)]
        public int QueuePosition { get; set; }

        [Display(Name = "Start time")]
        [Required]
        [DataType(DataType.Time)]
        public TimeSpan TimeOfStart { get; set; }

        [Display(Name = "Artist")]
        public int ArtistId { get; set; }
        public virtual Artist? Artist { get; set; }

        [Display(Name = "Event")]
        public int EventId { get; set; }
        public virtual Event? Event { get; set; }
    }
}
