using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetbizzzCore2.Repos.Models
{
    public class Role
    {
        public Role()
        {

        }

        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleCode { get; set; }

        public virtual IEnumerable<User> Users { get; set; }
        public virtual IEnumerable<Customer> Customers { get; set; }
    }
}
