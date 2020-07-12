using System;
using System.Collections.Generic;
using HealthySnacks.Models;

namespace HealthySnacks.Interfaces
{
    public interface IHealthySnacksRepository
    {
        IEnumerable<IHealthySnacksRepository> healthySnacks {get; set;}

        IHealthySnacksRepository GetHealthySnacksById(int Id);
       
    }
}
