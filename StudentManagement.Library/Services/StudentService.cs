using StudentManagement.Library.Models;
using StudentManagement.Library.Data;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement.Library.Services
{
    public class StudentService
    {
        // private List<Student> students = new List<Student>();

        private readonly AppDbContext _dbContext;

        public StudentService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // public IEnumerable<Student> GetAllStudents()
        // {
        //     return students;
        // }


        public IEnumerable<Student> GetAllStudents()
        {
            return _dbContext.Students.ToList();  // Fetch all students from the database
        }

        // public Student GetStudentById(int id)
        // {
        //     var student = students.Find(s => s.Id == id);
        //     if (student == null)
        //     {
        //         throw new KeyNotFoundException($"Student with ID {id} not found.");
        //     }
        //     return student;
        // }


        public Student GetStudentById(int id)
        {
            var student = _dbContext.Students.Find(id);
            if (student == null)
            {
                throw new KeyNotFoundException($"Student with ID {id} not found.");
            }
            return student;
        }

        // public void AddStudent(Student student)
        // {
        //     students.Add(student);
        //     Console.WriteLine($"Added student: {student.FirstName} {student.LastName} (ID: {student.Id})");
        // }

         public void AddStudent(Student student)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();  // Save changes to the database
        }

        // public void RemoveStudent(int id)
        // {
        //     var student = GetStudentById(id);
        //     if (student != null)
        //         students.Remove(student);
        // }

         public void RemoveStudent(int id)
        {
            var student = GetStudentById(id);
            if (student != null)
            {
                _dbContext.Students.Remove(student);
                _dbContext.SaveChanges();  // Persist the removal to the database
            }
        }

        // public void UpdateStudent(int id, Student updatedStudent)
        public void UpdateStudent(Student student)
        {
            _dbContext.Students.Update(student); // This updates the student in the DbContext
            _dbContext.SaveChanges(); // Save changes to the database
        }


    }
}