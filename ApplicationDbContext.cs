using Microsoft.EntityFrameworkCore;
using To_Do_List.Models;

namespace To_Do_List
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-A7K294K\\SQLEXPRESS;Initial Catalog=ToDoListDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
      public DbSet<Tasks> tasks { get; set; }
    }
}
