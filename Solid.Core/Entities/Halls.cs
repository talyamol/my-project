namespace EventHalls.Entities
{
    public class Halls
    {
        public int HallId { get; set; }
        public string Name { get; set; }
        public int CountParticipants { get; set; } = 300;
        public string City { get; set; }
        public string Street { get; set; }
        public string HallPhone { get; set; }
        static int id = 1;
        public Halls()
        {
            //HallId = id;
            //id++;
            
        }
    }
}
