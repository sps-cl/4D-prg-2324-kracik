using Školní.Models;

namespace Školní.Data
{
    public interface ITodoServicies
    {
        Task<bool> AddTodo(ToDo toDo);
        Task<List<ToDo>> GetTodoAll();
    }
}