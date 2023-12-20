using EventHalls.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IEventsService
    {
        List<Event> GetEvents();

        Event GetById(int id);
        Event AddEvents(Event event1);

        Event UpdateEvents(int id, Event e);

        void DeleteEvents(int id);
    }
}
