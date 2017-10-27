using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NetbizzzCore2.Repos.Models
{
    public class User
    {
        public User()
        {
            RoleId = 2;
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        [MinLength(4, ErrorMessage = "User Name should be 4 characters minimum")]
        [MaxLength(50)]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Password should be 6 characters minimum")]
        [MaxLength(50)]
        [Required(ErrorMessage = "Please type a Password")]
        public string Password { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        [Compare("Password", ErrorMessage = "Password cannot confirmed")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        [Required]
        [MaxLength(50)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Not valid email address")]
        public string Email { get; set; }

        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

    }
}
