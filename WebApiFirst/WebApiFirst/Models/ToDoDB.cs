using Microsoft.EntityFrameworkCore;

namespace WebApiFirst.Models
{
    public class ToDoDB:DbContext
    {
        public DbSet<TodoItem> Items { get; set; }

        public ToDoDB(DbContextOptions<ToDoDB> options)
        : base(options)
        {
        }

    }
}
