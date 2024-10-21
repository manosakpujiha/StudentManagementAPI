using StudentManagement.Library.Models;
using System.Collections.Generic;

namespace StudentManagement.Library.Services
{
    public class StudentService
    {
        private List<Student> students = new List<Student>();

        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }

    public Student GetStudentById(int id)
    {
        var student = students.Find(s => s.Id == id);
        if (student == null)
        {
            throw new KeyNotFoundException($"Student with ID {id} not found.");
        }
        return student;
    }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(int id)
        {
            var student = GetStudentById(id);
            if (student != null)
                students.Remove(student);
        }
    }
}