using System;
namespace HealthySnacks.Models
{
    public class HealthySnacks
    {
        public int Id { get; set; } //identifier for HealthySnack class

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; } //to create relations in the DB

        public virtual Category Category { get; set; }


        public HealthySnacks()
        {
        }
    }
}
