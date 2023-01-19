namespace EventRegestranionSystem.Models
{
    public class Performance
    {
        public int Id { get; set; }
        public int QueuePosition { get; set; }
        public TimeSpan TimeOfStart { get; set; }

        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }

        public int EventId { get; set; }
        public Event? Event { get; set; }
    }
}
