using Company.Common.DTOs;
using Company.Data.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDbService _db;
        public EmployeeController(IDbService db) => _db = db;
        [HttpGet]
        public async Task<IResult> Get() =>
        await _db.HttpGetAsync<Employee, EmployeeDTO>();

        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) =>
        await _db.HttpGetAsync<Employee, EmployeeDTO>(id);

        [HttpPost]
        public async Task<IResult> Post([FromBody] EmployeeDTO dto)
        => await _db.HttpPostAsync<Employee, EmployeeDTO>(dto);

        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] EmployeeDTO dto)
        => await _db.HttpPutAsync<Employee, EmployeeDTO>(dto, id);

        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.HttpDeleteAsync<Employee>(id);
    }
}
