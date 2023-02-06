using System.ComponentModel.DataAnnotations;

namespace AssignmentNo1.Models
{
    public class Student
    {
        public long Id { get; set; }
        [Required, MinLength(8), MaxLength(150)]
        public string? Name { get; set; }
        [Required, DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime DateOfBirth { get; set; }
        [Required, EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Address { get; set; }

        public virtual ICollection<Exam>? Exams { get; set; }
    }
}
