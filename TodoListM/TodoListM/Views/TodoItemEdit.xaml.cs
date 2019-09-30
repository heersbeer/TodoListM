using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TodoListM.Models;
using System.Windows.Input;

namespace TodoListM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoItemEdit : ContentPage
    {
        public ICommand SaveItemCommand => new Command(SaveItem);
        public TodoItemEdit(object tappedItem)
        {
            InitializeComponent();
            TodoItem itest = (TodoItem)tappedItem;
            Name_Entry.Text = itest.Name;
            Task_Editor.Text = itest.Task;
            Done_Check.IsChecked = itest.Done;
        }

        private void SaveItem()
        {

        }

        public TodoItemEdit()
        {
            InitializeComponent();
        }
    }
}