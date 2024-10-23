using Microsoft.EntityFrameworkCore;
using StudentManagement.Library.Models;
using StudentManagement.Library.Services;
using StudentManagement.Library.Data; 
using Xunit;

namespace StudentManagement.Tests
{
    public class StudentServiceTests
    {
        [Fact]
        public void AddStudent_ShouldAddStudentToList()
        // {
        //     // Arrange
        //     var service = new StudentService();
        //     var student = new Student { Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com" };

        //     // Act
        //     service.AddStudent(student);
        //     var result = service.GetAllStudents();

        //     // Assert
        //     Assert.Contains(student, result);
        // }
        {
            // Arrange: Set up an in-memory database
            var options = new DbContextOptionsBuilder<AppDbContext>()
                          .UseInMemoryDatabase(databaseName: "TestDb")
                          .Options;

            // Create a new instance of the in-memory AppDbContext
            var dbContext = new AppDbContext(options);

            // Create the StudentService with the in-memory DbContext
            var service = new StudentService(dbContext);

            // Create a student object
            var student = new Student { Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com" };

            // Act: Add the student and retrieve all students
            service.AddStudent(student);
            var result = service.GetAllStudents();

            // Assert: Verify that the student was added to the in-memory database
            Assert.Contains(student, result);
        }
    }
}