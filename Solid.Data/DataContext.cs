namespace EventHalls.Entities
{
    public class DataContext
    {
        //איפה את רואה את השגיאה?


        public List<Event> EventList { get; set; }
        public List<Invited> InvitedsList { get; set; }
        public List<Halls> HallsList { get; set; }
        public DataContext()
        {
            //DateTime date = DateTime.Today;
            //DateTime dateTime = date.Date;
            //בדקת שזה הסדר של הנתונים?
            //של התאריך?
            //כן 
            EventList = new List<Event>() {
            new Event() {Id=1,HallId=1,Name="Brit family perez",CountInvited=70,Date=new DateTime(2023,10,11)},
            new Event() {Id=2,HallId=2,Name="Wedding family choen & meir",CountInvited=300,Date=new DateTime(2023,12,12)},
            new Event() {Id=3,HallId = 3, Name="Bat mizva adi",CountInvited=50,Date=new DateTime(2023,12,11)},
            new Event() {Id=4,HallId = 1, Name="wedding family wias & tiz",CountInvited=250, Date=new DateTime(2023,11,28)} };

            InvitedsList = new List<Invited>()
            {
                new Invited(){Name="chana",IdEvent=1,Id=123456789},
                new Invited(){Name="sara",IdEvent=1,Id=123454569},
                new Invited(){Name="shimon",IdEvent=1,Id=214536989},
                new Invited(){Name="yeuda",IdEvent=3,Id=789456123},
                new Invited(){Name="shira",IdEvent=2,Id=784512963},
                new Invited(){Name="adi",IdEvent=2,Id=784596321},
                new Invited(){Name="yizchak",IdEvent=2,Id=967412853},
                new Invited(){Name="yosef",IdEvent=2,Id=025836914},
                new Invited(){Name="talya",IdEvent=3,Id=326379294},
                new Invited(){Name="yael",IdEvent=4,Id=784512963},
                new Invited(){Name="shay",IdEvent=4,Id=544123654},
            };

            HallsList = new List<Halls>()
            {
                new Halls(){City="Bene brak",CountParticipants=350,Name="hechale malchut",HallId = 1,Street="shlomo hamelech 3"},
                new Halls(){City="Bene brak",Name="armonot chen",HallId = 2,Street="shlomo hamelech 6"},
                new Halls(){City="Bene brak",CountParticipants=400,Name="hatraklin",HallId = 3,Street="shlomo hamelech 6"},
            };
        }
    }
}
