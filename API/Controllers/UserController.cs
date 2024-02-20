using API.Context;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class UserController : ApiBaseController
{
    readonly ApiDbContext apiContext; 
    public UserController(ApiDbContext context)
    {
        apiContext = context;
        apiContext.Database.EnsureCreated();
    }

    [HttpGet] 
    public IEnumerable<User> Get()=> apiContext.Users.Where(p => p.IsActived).ToList();

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult Get(string id)
    {
        var user = apiContext.Users.FirstOrDefault(u => u.UserId == IdValidator(id));
        if(user is null) return NotFound();
        return Ok(user);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult> Post([FromBody] User user)
    {
        apiContext.Users.Add(user);
        await apiContext.SaveChangesAsync();
        return Created();
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Put(string id, [FromBody] User user)
    {
        var userFound = apiContext.Users.FirstOrDefault(u => u.UserId == IdValidator(id));
        if (userFound is null) return NotFound();

        userFound.Name = user.Name;
        userFound.LastName = user.Name;
        userFound.IsActived = user.IsActived;
        await apiContext.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Delete(string id)
    {
        var userFound = apiContext.Users.FirstOrDefault(u => u.UserId == IdValidator(id));
        if (userFound is null) return NotFound();
        userFound.IsActived = !userFound.IsActived;
        await apiContext.SaveChangesAsync();
        return NoContent();
    }
     private Guid IdValidator(string id)
    {
        if (!Guid.TryParse(id, out var UserId) || UserId == Guid.Empty)
            throw new ArgumentException("Invalid Id");
        return UserId;
    }
}
