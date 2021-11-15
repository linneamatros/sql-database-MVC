using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplication1.Entities
{
    public partial class Address
    {
        public Address()
        {
            Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string AddressLine { get; set; }
        public int Number { get; set; }
        public int ZipCode { get; set; }
        [Required]
        public string City { get; set; }

        [InverseProperty(nameof(User.Address))]
        public virtual ICollection<User> Users { get; set; }
    }
}
