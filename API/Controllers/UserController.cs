using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/{controller}")]
public class UserController:ControllerBase
{
    private readonly DataDbContext _dbContext;
    public UserController(DataDbContext dbContext)
    {
        _dbContext=dbContext;
    }
[HttpGet]
public async Task<ActionResult<IEnumerable<AppUser>>> GetAppUsers()
{
    var users=await _dbContext.Users.ToListAsync<AppUser>();

    return users;
}

[HttpGet("{id}")]
public async Task<ActionResult<AppUser>> GetAppUser(int id)
{
    var user=await _dbContext.Users.FindAsync(id);
    if(user==null) return NotFound();
    return user;
}


}
