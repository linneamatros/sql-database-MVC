using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sql_database_project.Models
{
    public class Address
    {


        [Key]

        public int Id { get; set; }

        [Required]
        public string AddressLine { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public int ZipCode { get; set; }

        [Required]
        public string City { get; set; }

        public virtual ICollection<User> Users {get; set; }




    }
}
