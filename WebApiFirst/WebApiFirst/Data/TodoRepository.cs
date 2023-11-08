using Microsoft.EntityFrameworkCore;
using WebApiFirst.Models;

namespace WebApiFirst.Data
{
    public class TodoRepository:ITodoRepository
    {
        ToDoDB _context;

        public TodoRepository(ToDoDB db)
        {
            _context = db;  
        }

        public async Task AddItem(TodoItem item)
        {
            await _context.AddAsync(item);
        }

        public Task DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TodoItem>> GetAll()
        {
            return await _context.Items.ToListAsync();
        }
        
        public async Task<TodoItem> GetById(long id)
        {
            return await _context.Items.FindAsync(id);
        }

        public Task UpdateItem(TodoItem item)
        {
            _context.Update(item);
            return Task.CompletedTask;
        }
    }
}
