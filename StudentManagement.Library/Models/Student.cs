using System.ComponentModel.DataAnnotations;


namespace StudentManagement.Library.Models
{
   public class Student
{
  
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty; // Initialize with default value

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;  // Initialize with default value
    
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;     // Initialize with default value
}
}