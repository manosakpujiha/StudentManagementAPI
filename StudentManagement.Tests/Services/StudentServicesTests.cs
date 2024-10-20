using StudentManagement.Library.Models;
using StudentManagement.Library.Services;
using Xunit;

namespace StudentManagement.Tests
{
    public class StudentServiceTests
    {
        [Fact]
        public void AddStudent_ShouldAddStudentToList()
        {
            // Arrange
            var service = new StudentService();
            var student = new Student { Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com" };

            // Act
            service.AddStudent(student);
            var result = service.GetAllStudents();

            // Assert
            Assert.Contains(student, result);
        }
    }
}