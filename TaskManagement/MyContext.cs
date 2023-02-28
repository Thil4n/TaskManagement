using System.Xml;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


public class MyContext : DbContext
{
    public DbSet<Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("server=127.0.0.1;port=3306;uid=thilan;pwd=p455w07d;database=taskmanagement", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));
        }
    }
}

