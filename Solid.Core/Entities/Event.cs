namespace EventHalls.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public int HallId { get; set; }
        public string Name { get; set; }
        public int CountInvited { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartHour { get; set; }
        public int MinAge { get; set; }

    }
}
