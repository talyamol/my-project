using EventHalls.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class HallsRepository : IHallsRepository
    {
        private readonly DataContext _context;
        public HallsRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public Halls AddHalls(Halls halls)
        {
            _context.HallsList.Add(halls);
            return halls;
        }

        public void Deletehalls(int id)
        {
            _context.HallsList.Remove(_context.HallsList.Find(x => x.HallId == id));
        }

        public Halls GetById(int id)
        {
            return _context.HallsList.Find(x => x.HallId == id);
        }

        public List<Halls> GetHalls()
        {
            return _context.HallsList;
        }

        public Halls UpdateHalls(int id, Halls halls)
        {
            var updateHalls = _context.HallsList.Find(x => x.HallId == id);
            if (updateHalls != null)
            {
                updateHalls.HallId = halls.HallId;
                updateHalls.HallPhone = halls.HallPhone;
                updateHalls.CountParticipants=halls.CountParticipants;
                updateHalls.Street = halls.Street;
                updateHalls.Name = halls.Name;
                updateHalls.City= halls.City;
                return updateHalls;
            }
            return null;
        }
    }
}
