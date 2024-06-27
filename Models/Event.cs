namespace EventEase.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string EventName { get; set; } = "";
        public DateTime EventData { get; set; } = DateTime.Now;
    }
}
