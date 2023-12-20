using EventHalls.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class EventsService : IEventsService
    {
        private readonly IEventRepository _eventsRepository;

        public EventsService(IEventRepository eventsRepository)
        {
            _eventsRepository = eventsRepository;
        }
        public Event GetById(int id)
        {
           return _eventsRepository.GetById(id);
        }

        public List<Event> GetEvents()
        {
           return _eventsRepository.GetEvents();
        }
        public Event AddEvents(Event event1)
        {
            return _eventsRepository.AddEvents(event1);
        }

        public Event UpdateEvents(int id, Event e)
        {
            return _eventsRepository.UpdateEvents(id, e);
        }

        public void DeleteEvents(int id)
        {
            _eventsRepository.DeleteEvents(id);
        }

        
    }
}
