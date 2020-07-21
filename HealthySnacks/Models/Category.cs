using System.Collections.Generic;

namespace EatMoreHealthySnacks.Models
{
    public class Category
    {
        public int CategoryId { get; set; } //identifier for category class or model

        public string CategoryName { get; set; } //fruit leather or nut bar

        public string Description { get; set; } // short description for each category

        public List<HealthySnacks> Snacks { get; set; } //Entity framework will make one to many relationship between Category and CategoryId
    }
}