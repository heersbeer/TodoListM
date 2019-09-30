using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using TodoListM.Models;
using TodoListM.ViewModels.Base;
using Xamarin.Forms;

namespace TodoListM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private DateTime? _finishTime;
        public ICommand AddTodoItemCommand => new Command(async () => await AddTodoItemAsync());
        public ICommand SynchronousCommand => new Command(SynchronousAction);
        public ICommand AsynchronousCommand => new Command(async () => await AsynchronousAction());
               
        public MainViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>
            {
                new TodoItem("Hond", "Uitlaten", true),
                new TodoItem("Gees", "Wroah"),
                new TodoItem("Wollie", "Njaah"),
                new TodoItem("Alexis", "Cockfag"),
            };
        }

        // TIP: Properties zijn eenvoudiger in te tikken door simpelweg in VisualStudio
        // op een lege regel `prop` in te tikken gevolgd door 2x tab.        
        private ObservableCollection<TodoItem> _todoItems;
        public ObservableCollection<TodoItem> TodoItems
        {
            get { return _todoItems; }
            set { _todoItems = value; RaisePropertyChanged(() => TodoItems); }
        }

        private async Task AddTodoItemAsync()
        {
            // TIP: Je kan `Console` gebruiken om tekst weer te geven in de Application Output tab
            // als de app actief is. Kan handig zijn voor debuggen. Naast Console.WriteLine() is er
            // ook Debug.WriteLine(). Console.WriteLine() wordt altijd weergegeven, maar
            // Debug.WriteLine() alleen in Debug builds.
            //
            // Hier voeg ik logging toe om te zien of het commando goed wordt aangeroepen.
            System.Diagnostics.Debug.WriteLine("AddTodoItemAsync");

            await NavigationService.NavigateToAsync<TodoItemViewModel>();
        }

        private async Task AsynchronousAction()
        {
            if (_finishTime != null) { return; }

            await Task.Run(() => DoWork());
        }

        private void SynchronousAction()
        {
            if (_finishTime != null) { return; }

            DoWork();
        }

        private void DoWork()
        {
            _finishTime = DateTime.Now.AddSeconds(5);

            while (true)
            {
                var diff = DateTime.Now.CompareTo(_finishTime);
                Console.WriteLine($"diff: {diff}");

                Thread.Sleep(100);

                if (diff > 0) { break; }
            }

            _finishTime = null;

            Console.WriteLine("finished");
        }


    }
}
