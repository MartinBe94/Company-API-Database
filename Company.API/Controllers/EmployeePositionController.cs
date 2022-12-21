using Company.API.Extensions;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeePositionController : ControllerBase
    {
        private readonly IDbService _db;
        public EmployeePositionController(IDbService db) => _db = db;

        [HttpPost]
        public async Task<IResult> Post(EmployeePositionDTO dto)=>
            await _db.HttpAddAsync<EmployeePosition,EmployeePositionDTO>(dto);

        [HttpDelete]
        public async Task<IResult> Delete(EmployeePositionDTO dto) =>
            await _db.HttpDeleteAsync<EmployeePosition, EmployeePositionDTO>(dto);
    }
}
