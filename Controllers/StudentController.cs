using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesttDeployApiWithEFcoreAndDocker.Database;
using TesttDeployApiWithEFcoreAndDocker.Database.Entities;

namespace TesttDeployApiWithEFcoreAndDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DatabaseContext context;

        public StudentController(DatabaseContext context)
        {
            this.context = context;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetStudentAll()
        {
            var students = await context.Student.ToListAsync();
            return Ok(students);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddStudent([FromBody]Student student)
        {
            student.StudentGUID = Guid.NewGuid();
            context.Student.Add(student);
            await context.SaveChangesAsync();
            return Ok(student);
        }
    }
}
