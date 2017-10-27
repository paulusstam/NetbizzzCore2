using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NetbizzzCore2.Repos.Models
{
    public class Customer
    {
        public Customer()
        {
            RoleId = 3;
        }

        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        [NotMapped]
        public string ConfirmPassword { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public string HomePhone { get; set; }

        public string MobilePhone { get; set; }

        public string Company { get; set; }

        public string CompanyType { get; set; }

        public string VATNumber { get; set; }

        public string Doy { get; set; }

        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }
}
