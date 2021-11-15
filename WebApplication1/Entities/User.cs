using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplication1.Entities
{
    [Index(nameof(AddressId), Name = "IX_Users_AddressId")]
    [Index(nameof(Email), Name = "IX_Users_Email", IsUnique = true)]
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public int? AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty("Users")]
        public virtual Address Address { get; set; }
    }
}
