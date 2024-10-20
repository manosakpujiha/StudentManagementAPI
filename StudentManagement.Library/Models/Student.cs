namespace StudentManagement.Library.Models
{
   public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty; // Initialize with default value
    public string LastName { get; set; } = string.Empty;  // Initialize with default value
    public string Email { get; set; } = string.Empty;     // Initialize with default value
}
}