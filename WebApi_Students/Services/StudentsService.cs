using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_lesson2.Models;

namespace WebApi_lesson2.Services
{
    public class StudentsService : IStudentsService
    {
        private List<Student> _students;

        public StudentsService()
        {
            _students = new List<Student>();
        }

        public async Task<int> AddStudent(Student student)
        {
            if (_students.Count == 0) student.Id = 1;
            else student.Id = _students[_students.Count-1].Id+1;
            _students.Add(student);

            return student.Id ?? -1;
        }

        public async Task<bool> DeleteStudent(int id)
        {
            int idx = _students.FindIndex(x => x.Id == id);
            if (idx == -1) return false;
            _students.RemoveAt(idx);
            return true;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return _students;
        }

        public async Task<Student> GetStudent(int id)
        {
            return _students.Find(x => x.Id == id);
        }

        public async Task<bool> UpdateStudent(int id, Student student)
        {
            student.Id = id;
            int idx = _students.FindIndex(x => x.Id == id);
            if (idx == -1) return false;
            _students[idx] = student;
            return true;
        }
    }
}
