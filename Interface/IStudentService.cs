using EF_Core_1.DTO;

namespace EF_Core_1.Interface
{
    public interface IStudentService
    {
        Task<StudentDTO> Add(StudentDTO student);
        Task<StudentDTO> Edit(StudentDTO student, int id);
        Task Delete(int id);
        Task<List<StudentDTO>> GetAllStudent();
        Task<StudentDTO> GetStudentById(int id);
    }
}