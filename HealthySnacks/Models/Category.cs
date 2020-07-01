using System.Collections.Generic;

namespace HealthySnacks.Models
{
    public class Category
    {
        public int CategoryId { get; set; } //identifier for category class or model

        public string CategoryName { get; set; } //fruit leather or nut bar

        public string Description { get; set; } // short description for each category

        public List<HealthySnacks> List { get; set; }
    }
}