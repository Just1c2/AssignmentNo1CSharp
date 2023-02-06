using System.ComponentModel.DataAnnotations;

namespace AssignmentNo1.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }

        [Required, StringLength(150, MinimumLength = 8)]
        public string? SubjectName { get; set; }

        [Required, StringLength(20, MinimumLength = 2)]
        public string? SubjectCode { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime EndDate { get; set; }

        public virtual ICollection<Exam>? Exams { get; set; }
    }
}
