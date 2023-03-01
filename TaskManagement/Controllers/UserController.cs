using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UserManagement.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    [HttpGet(Name = "GetUser")]
    public List<User> GetUsers()
    {
        var myContext = new MyContext();
        return myContext.Users.ToList();
    }

    [HttpPost(Name = "CreateUser")]
    public IActionResult CreateUser([FromBody] User newUser)
    {
        var myContext = new MyContext();

        myContext.Users.Add(newUser);
        myContext.SaveChanges();
        return Ok($"User inserted successfully");
    }

    [HttpPatch(Name = "UpdateUser")]
    public IActionResult UpdateUser([FromBody] User newUser)
    {
        var myContext = new MyContext();

        myContext.Users.Update(newUser);
        myContext.SaveChanges();
        return Ok($"User updated successfully");
    }


    [HttpDelete("{userId}")]
    public IActionResult DeleteUser([FromRoute] int userId)
    {
        var myContext = new MyContext();

        User user = new User() { Id = userId };
        myContext.Users.Attach(user);
        myContext.Users.Remove(user);
        myContext.SaveChanges();

        return Ok($"User with ID {userId} has been deleted.");
    }

}

