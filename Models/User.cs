using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNTU_JOBS.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        [ForeignKey("RoleId")]
        public int RoleId { get; set; } // Foreign key
        public Role Role { get; set; } // Navigator property

    }
}
