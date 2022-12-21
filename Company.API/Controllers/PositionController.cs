﻿using Company.Common.DTOs;
using Company.Data.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PositionController : ControllerBase
{
    private readonly IDbService _db;
    public PositionController(IDbService db) => _db = db;
    [HttpGet]
    public async Task<IResult> Get() =>
    await _db.HttpGetAsync<Position, PositionDTO>();

    [HttpGet("{id}")]
    public async Task<IResult> Get(int id) =>
    await _db.HttpGetAsync<Position, PositionDTO>(id);

    [HttpPost]
    public async Task<IResult> Post([FromBody] PositionDTO dto)
    => await _db.HttpPostAsync<Position, PositionDTO>(dto);

    [HttpPut("{id}")]
    public async Task<IResult> Put(int id, [FromBody] PositionDTO dto)
    => await _db.HttpPutAsync<Position, PositionDTO>(dto, id);

    [HttpDelete("{id}")]
    public async Task<IResult> Delete(int id) =>
        await _db.HttpDeleteAsync<Position>(id);
}
