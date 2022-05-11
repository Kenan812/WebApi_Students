using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi_lesson2.Models;

namespace WebApi_lesson2
{
    public interface IStudentsService
    {
        Task<Student> GetStudent(int id);
        Task<IEnumerable<Student>> GetAllStudents();
        Task<int> AddStudent(Student student);
        Task<bool> DeleteStudent(int id);
        Task<bool> UpdateStudent(int id, Student student);
    }
}
