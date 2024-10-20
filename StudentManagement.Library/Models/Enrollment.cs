namespace StudentManagement.Library.Models
{
   public class Enrolment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrolmentDate { get; set; } = DateTime.Now; // Initialize with default value
        // Add other properties as needed
    }
}