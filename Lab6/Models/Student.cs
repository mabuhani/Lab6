using System.ComponentModel.DataAnnotations;

namespace Lab6.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        [Required]
        public string StudentNumber { get; set; }
        [Required]
        public string Email { get; set; }
        public string Program { get; set; }
    }
}
