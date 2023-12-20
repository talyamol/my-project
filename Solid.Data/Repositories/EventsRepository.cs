using EventHalls.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class EventsRepository : IEventRepository
    {
        private readonly DataContext _context;
        public EventsRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public Event AddEvents(Event event1)
        {
            _context.EventList.Add(event1);
            return event1;
        }

        public void DeleteEvents(int id)
        {
            _context.EventList.Remove(_context.EventList.Find(x => x.Id == id));
        }

        public Event GetById(int id)
        {
            return _context.EventList.Find(x => x.Id == id);
        }

        public List<Event> GetEvents()
        {
            return _context.EventList;
        }

        public Event UpdateEvents(int id, Event event1)
        {
            var updateEvents = _context.EventList.Find(x => x.Id == id);
            if (updateEvents != null)
            {
                updateEvents.StartHour = event1.StartHour;
                updateEvents.CountInvited=event1.CountInvited;
                updateEvents.MinAge=event1.MinAge;
                updateEvents.Date=event1.Date;
                updateEvents.HallId=event1.HallId;
                updateEvents.Id = event1.Id;
                updateEvents.Name=event1.Name;
                return updateEvents;
            }
            return null;
        }
    }
}
