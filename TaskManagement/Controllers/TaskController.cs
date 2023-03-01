using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TaskManagement.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{

    [HttpGet(Name = "GetTask")]
    public List<Task> GetTasks()
    {
        var myContext = new MyContext();
        return myContext.Tasks.ToList();
    }

    [HttpPost(Name = "CreateTask")]
    public IActionResult CreateTask([FromBody] Task newTask)
    {
        var myContext = new MyContext();

        myContext.Tasks.Add(newTask);
        myContext.SaveChanges();
        return Ok($"Task inserted successfully");
    }

    [HttpPatch(Name = "UpdateTask")]
    public IActionResult UpdateTask([FromBody] Task newTask)
    {
        var myContext = new MyContext();

        myContext.Tasks.Update(newTask);
        myContext.SaveChanges();
        return Ok($"Task updated successfully");
    }


    [HttpDelete("{taskId}")]
    public IActionResult DeleteTask([FromRoute] int taskId)
    {
        var myContext = new MyContext();

        Task task = new Task() { Id = taskId };
        myContext.Tasks.Attach(task);
        myContext.Tasks.Remove(task);
        myContext.SaveChanges();

        return Ok($"Task with ID {taskId} has been deleted.");
    }

}

