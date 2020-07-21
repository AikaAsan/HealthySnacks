using System;
using System.Collections.Generic;
using HealthySnacks.Models;
using HealthySnacks.Entities;

namespace HealthySnacks.Interfaces
{
    public interface IHealthySnacksRepository
    {
        IEnumerable<HealthySnacks> healthySnacks { get; set; } //property will be used to get all drinks

        HealthySnacks GetHealthySnacksById(int Id); //method 

    }
}
