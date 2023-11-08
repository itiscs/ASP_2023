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
            await _context.SaveChangesAsync();
        }

        public async Task DeleteById(long id)
        {
            var item = _context.Items.Find(id);
            if (item != null)
            {
                _context.Remove(item);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<TodoItem>> GetAll()
        {
            return await _context.Items.ToListAsync();
        }
        
        public async Task<TodoItem> GetById(long id)
        {
            return await _context.Items.FindAsync(id);
        }

        public async Task UpdateItem(TodoItem item)
        {
            _context.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}
