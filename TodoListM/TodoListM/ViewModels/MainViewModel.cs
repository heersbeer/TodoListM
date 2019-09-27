using System.Collections.Generic;
using System.Windows.Input;
using TodoListM.Models;
using TodoListM.Services;
using TodoListM.ViewModels.Base;

namespace TodoListM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            var service = new TodoItemServices();

            TodoItemList = service.GetTodoItems();
        }
        private List<TodoItem> todoItems;
        public List<TodoItem> TodoItemList
        {
            get { return todoItems; }
            set { SetProperty(ref todoItems, value); }
        }
       
    }
}
