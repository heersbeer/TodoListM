using System.Collections.Generic;
using TodoListM.Models;

namespace TodoListM.Services
{
    public class TodoItemServices
    {
        public TodoItemServices()
        {
        }

        public List<TodoItem> GetTodoItems()
        {
            var list = new List<TodoItem>
            {
                new TodoItem
                {
                    Name = "Hond",
                    Task = "Uitlaten"
                },
                new TodoItem
                {
                    Name = "Hond2",
                    Task = "Uitlaten"
                },
                new TodoItem
                {
                    Name = "Hond3",
                    Task = "Uitlaten"
                },
            };
            return list;
        }
         
    }
}
