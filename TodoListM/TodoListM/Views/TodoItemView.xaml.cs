using TodoListM.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoListM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoItemView : ContentPage
    {
        public TodoItemView(object tappedItem)
        {
            InitializeComponent();
            TodoItem itest = (TodoItem)tappedItem;
            Name_Entry.Text = itest.Name;
            Task_Editor.Text = itest.Task;
            Done_Check.IsChecked = itest.Done;

        }
    }
}