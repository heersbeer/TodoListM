using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TodoListM.Models;
using TodoListM.Services;
using TodoListM.ViewModels.Base;
using Xamarin.Forms;

namespace TodoListM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        // Deze definieren zodat je ook buiten de contructor toegang hebt
        TodoItemServices service;
        public MainViewModel()
        {
            service = new TodoItemServices();
            TodoItemList = service.GetTodoItems();
        }

        private ObservableCollection<TodoItem> todoItems;
        public ObservableCollection<TodoItem> TodoItemList
        {
            get { return todoItems; }
            set { SetProperty(ref todoItems, value); }
        }

        public ICommand AddItemCommand => new Command(AddTodoItem);
        private void AddTodoItem()
        {
        
        }


    }
}
