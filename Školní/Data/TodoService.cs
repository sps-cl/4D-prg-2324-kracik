using Školní.Models;

namespace Školní.Data
{
    private class ITodoService
    {
        List<Todo> _Todo = new List<Todo>();

        public async Task<bool> AddTodo(ToDo toDo)
        {
            toDo.Id = Guid.NewGuid();

            toDo.CreatedData = DateTime.Now;

            //v reálném světě by probehlo ulozeni do DB
            _Todo.Add(toDo);

            return true;
        }

        public async Task<List<ToDo>> GetTodoAll()
        {
           
            return _Todo.OrderBy(x => x.CreatedData).ToList();
        }



    }
}
