using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectAspGroup.Models
{
    [Table("UserInfo")]
    public class UserInfo
    {
        [Display(Name ="User ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [Display(Name = "User Name")]
        [Required]
        [MinLength(2)]
        [StringLength(60)]
        [Column("varchar")]
        public string UserName{ get; set; }

        [Required(ErrorMessage = "Field cant be empty.")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid Email..!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name ="Display Name")]
        [Required]
        [MinLength(5)]
        [StringLength(60)]
        [Column("varchar")]
        public string DisplayName { get; set; }

        [Display(Name =" Gender")]
        [Required]

        public string Gender { get; set; }

    }
}
