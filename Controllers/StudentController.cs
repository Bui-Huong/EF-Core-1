using Microsoft.AspNetCore.Mvc;
using EF_Core_1.Interface;
using EF_Core_1.DTO;
using EF_Core_1.Entities;

namespace EF_Core_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpPost("/add-student")]
        public async Task Add(StudentDTO student)
        {
            await _studentService.Add(student);
        }
        [HttpPut("/edit-student")]
        public async Task Edit(Student student)
        {
            await _studentService.Edit(student);
        }
        [HttpDelete("/delete-student")]
        public async Task Delete(int id)
        {
            await _studentService.Delete(id);
        }
        [HttpGet("/get-all-student")]
        public async Task<List<Student>> GetAllStudent()
        {
            return await _studentService.GetAllStudent();
        }
        [HttpGet("/get-student-by-id")]
        public async Task<List<Student>> GetStudentById(int id)
        {
            return await _studentService.GetStudentById();
        }
    }
}