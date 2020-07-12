using System;
using System.Collections.Generic;
using HealthySnacks.Models;

namespace HealthySnacks.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; set; }
    }
}
