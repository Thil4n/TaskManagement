using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string ?Avatar { get; set; }

}
