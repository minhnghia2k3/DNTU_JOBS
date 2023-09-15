using System.ComponentModel.DataAnnotations;

namespace DNTU_JOBS.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
        public List<User> Users { get; set; } //Navigator property
    }
}
