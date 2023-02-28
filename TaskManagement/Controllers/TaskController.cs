using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

    [HttpPost(Name = "CreateTask")]
    public Boolean Create([FromBody] Task newTask)
    {
        var myContext = new MyContext();

        myContext.Tasks.Add(newTask);
        return true;
    }

    [HttpPatch(Name = "UpdateTask")]
    public Boolean Update([FromBody] Task newTask)
    {
        var myContext = new MyContext();

        myContext.Tasks.Update(newTask);
        return true;
    }


    [HttpDelete(Name = "DeleteTask")]
    public Boolean Delete([FromBody] Task newTask)
    {
        var myContext = new MyContext();

        myContext.Tasks.Delete(newTask);
        return true;
    }
}

