using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Models
{
    public class Artist
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string? Name { get; set; }

        [Display(Name = "Number of members")]
        [Required]
        [Range(1, 30)]
        public int NumberOfMembers { get; set; }

        [Display(Name = "Email")]
        [Required]
        [EmailAddress]
        public string? EmailAddress { get; set; }


        public virtual ICollection<Performance>? Performances { get; set; }
    }
}
