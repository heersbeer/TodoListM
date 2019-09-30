using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TodoListM.Models
{
    public class TodoItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Name));
            }
        }
        private string _task;
        public string Task
        {
            get => _task;
            set
            {
                _task = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Task));
            }
        }
        private bool _done;
        public bool Done
        {
            get => _done;
            set => _done = value;
        }

        public TodoItem(string name, string task, bool isDone = false)
        {
            Name = name;
            Task = task;
            Done = isDone;
        }
    }
}
