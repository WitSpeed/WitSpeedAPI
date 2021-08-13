using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

using Microsoft.AspNetCore.Identity;

namespace WitSpeed.Models.Models
{
    public class AppUser: IdentityUser
    {
        [Column(TypeName ="VARCHAR(25)")]
        public string FirstName { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string LastName { get; set; }

        [Column(TypeName = "VARCHAR(25)")]
        public string Gender { get; set; }

        public Address Address { get; set; }

        public Driver Driver { get; set; }

        public Customer Customer { get; set; }

        public Avatar Avatar { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
    }
}
