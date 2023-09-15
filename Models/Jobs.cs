using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNTU_JOBS.Models
{
    public class Jobs
    {
        [Key]
        public int JobId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Salary { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("PostedById")]
        public int PostedById { get; set; }
        public User PostedBy { get; set; }

    }
}
