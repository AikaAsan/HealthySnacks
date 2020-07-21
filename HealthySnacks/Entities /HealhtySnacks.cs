using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HealthySnacks.Models;

namespace HealthySnacks.Entities

{
    [Table ("HealthySnacks")]

    public class HealhtySnacks
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }


        [Column("Name")]
        public string Name { get; set; }


        [Column("Description")]     
        public string Description { get; set; }


        [Column("Price")]      
        public decimal Price { get; set; }


        [Column("ImageUrl")]       
        public string ImageUrl { get; set; }



        [Column("CategoryId")]     
        public int CategoryId { get; set; }



        [Column("Category")]      
        public virtual Category Category { get; set; }

 
    }
}
