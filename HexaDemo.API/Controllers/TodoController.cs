using HexaDemo.Modules.Domain.Entities;
using HexaDemo.Modules.Domain.Interfaces;
using HexaDemo.Modules.Domain.QueryObjects;
using Microsoft.AspNetCore.Mvc;

namespace HexaDemo.API.Controllers;

[ApiController]
[Route("todo/api/v1")]
public class TodoController : ControllerBase
{
    private readonly ITodoRepository _todoRepository;
    
    public TodoController(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }
    
    [HttpPost("cards")]
    public async Task<IActionResult> CreateCard([FromBody] string title, Guid userId)
    {
        var user = await _todoRepository.GetUser(userId);
        var card = new CreateCardQueryObject(title, user);
        await _todoRepository.CreateCard(card);
        return Ok(card);
    }
}