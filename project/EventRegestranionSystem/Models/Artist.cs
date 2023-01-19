using System.ComponentModel.DataAnnotations;

namespace EventRegestranionSystem.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int NumberOfMembers { get; set; }
        public string? EmailAddress { get; set; }

        public Performance? Performance { get; set; }
    }
}
