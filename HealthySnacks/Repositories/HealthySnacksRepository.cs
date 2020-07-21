using System;
using System.Collections.Generic;
using System.Linq;
using HealthySnacks.Entities;
using HealthySnacks.Interfaces;
using HealthySnacks.Models;


namespace HealthySnacks.Repositories
{
    public class HealthySnacksRepository : IHealthySnacksRepository
    {
        public HealthySnacksRepository()
        {
        }


        //have no idea what the code below means

        public IEnumerable<IHealthySnacksRepository> healthySnacks => throw new NotImplementedException();

        public IHealthySnacksRepository GetHealthySnacksById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
