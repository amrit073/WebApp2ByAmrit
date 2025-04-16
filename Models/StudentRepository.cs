using System.Collections.Generic;
using System.Linq;

namespace WebApp2ByAmrit.Models
{
    public class StudentRepository
    {
        private List<Student> _students = new List<Student>();

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public Student GetStudent(int id)
        {
            return _students.FirstOrDefault(s => s.StdID == id);
        }

        public List<Student> GetAllStudents()
        {
            return _students;
        }
    }
} 