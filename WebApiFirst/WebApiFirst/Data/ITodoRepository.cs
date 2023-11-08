using WebApiFirst.Models;

namespace WebApiFirst.Data
{
    public interface ITodoRepository
    {
        Task<IEnumerable<TodoItem>> GetAll(); 
        Task<TodoItem> GetById(long id);
        Task AddItem(TodoItem item);
        Task UpdateItem(TodoItem item);
        Task DeleteById(long id);

    }
}
