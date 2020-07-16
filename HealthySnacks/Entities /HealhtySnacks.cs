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
        [Key]
        public string Name { get; set; }


        [Column("Description")]
        [Key]
        public string Description { get; set; }


        [Column("Price")]
        [Key]
        public decimal Price { get; set; }


        [Column("ImageUrl")]
        [Key]
        public string ImageUrl { get; set; }



        [Column("CategoryId")]
        [Key]
        public int CategoryId { get; set; }

        [Column("Category")]
        [Key]
        public virtual Category Category { get; set; }

 
    }
}
