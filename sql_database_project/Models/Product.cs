using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sql_database_project.Models
{
    public class Product
    {


        [Key]

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

         [Required]
        public string Shorts { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        public virtual string ImageUrl { get; set; }
    }
}
