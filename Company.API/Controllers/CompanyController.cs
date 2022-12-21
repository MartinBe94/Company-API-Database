using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
    private readonly IDbService _db;
    public CompanyController(IDbService db) => _db = db;

    [HttpGet]
    public async Task<IResult> Get() =>
         await _db.HttpGetAsync<Data.Entities.Company, CompanyDTO>();

    [HttpGet("{id}")]
    public async Task<IResult> Get(int id) =>
         await _db.HttpGetAsync<Data.Entities.Company, CompanyDTO>(id);

    [HttpPost]
    public async Task<IResult> Post([FromBody] CompanyDTO dto)
        => await _db.HttpPostAsync<Data.Entities.Company, CompanyDTO>(dto);

    [HttpPut("{id}")]
    public async Task<IResult> Put(int id, [FromBody] CompanyDTO dto)
     => await _db.HttpPutAsync<Data.Entities.Company, CompanyDTO>(dto, id);

    [HttpDelete("{id}")]
    public async Task<IResult> Delete(int id) =>
        await _db.HttpDeleteAsync<Data.Entities.Company>(id);
}
