using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplication1.Entities
{
    public partial class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Shorts { get; set; }
        [Required]
        public string Description { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
