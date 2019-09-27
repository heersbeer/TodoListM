using System.Collections.Generic;
using System.Collections.ObjectModel;
using TodoListM.Models;

namespace TodoListM.Services
{
    public class TodoItemServices
    {
        public TodoItemServices()
        {
        }

        public ObservableCollection<TodoItem> GetTodoItems()
        {
            var list = new ObservableCollection<TodoItem>
            {
                new TodoItem
                {
                    Name = "Hond",
                    Task = "Uitlaten",
                    Done = true
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
