using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi_lesson2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi_lesson2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsService _studentsService;
        public StudentsController(IStudentsService studentsService)
        {
            _studentsService = studentsService;
        }
        
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok( await _studentsService.GetAllStudents());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _studentsService.GetStudent(id));

        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Student value)
        {
            return Ok(await _studentsService.AddStudent(value));
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Student value)
        {
            return Ok(await _studentsService.UpdateStudent(id, value));
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _studentsService.DeleteStudent(id));
        }
    }
}
