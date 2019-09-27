using System.Windows.Input;
using Xamarin.Forms;
using TodoListM.Models;
using TodoListM.ViewModels;


namespace TodoListM.ViewModels
{
    class TodoItemViewModel
    {

        public ICommand SaveCommand => new Command(SaveTodoItem);
        private void SaveTodoItem()
        {
            //TodoItemList.Add(new TodoItem { Name = "Henk", Task = "Hondehond" });
        }
    }
}
