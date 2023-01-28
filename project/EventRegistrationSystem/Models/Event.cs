using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [DisplayFormat(NullDisplayText = "No descripton")]
        public string? Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public virtual ICollection<Performance>? Performances { get; set; }
    }
}
