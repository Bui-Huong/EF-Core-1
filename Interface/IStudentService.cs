using EF_Core_1.DTO;
using EF_Core_1.Entities;

namespace EF_Core_1.Interface
{
    public interface IStudentService
    {
        StudentDTO GetStudent(int id);
        Task<Student> Add(StudentDTO student);
        Task<Student> Edit(Student student);
        Task Delete(int id);
        Task<List<Student>> GetAllStudent();
        Task<Student> GetStudentById();
    }
}