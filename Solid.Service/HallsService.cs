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
    public class HallsService : IHallsService
    {
        private readonly IHallsRepository _hallsRepository;

        public HallsService(IHallsRepository hallsRepository)
        {
            _hallsRepository = hallsRepository;
        }
        public Halls GetById(int id)
        {
           return _hallsRepository.GetById(id);
        }

        public List<Halls> GetHalls()
        {
            return _hallsRepository.GetHalls();
        }
        public Halls AddHalls(Halls hall)
        {
            return _hallsRepository.AddHalls(hall);
        }

        public Halls UpdateHalls(int id, Halls h)
        {
            return _hallsRepository.UpdateHalls(id, h);
        }

        public void DeleteHalls(int id)
        {
            _hallsRepository.Deletehalls(id);
        }
    }
}

