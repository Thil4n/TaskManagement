using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{

    [HttpGet(Name = "GetTask")]
    public List<Task> Get()
    {
        var myContext = new MyContext();
        return myContext.Tasks.ToList();
    }
}

