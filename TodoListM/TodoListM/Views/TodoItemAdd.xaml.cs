using System.Windows.Input;
using TodoListM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoListM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoItemAdd : ContentPage
    {
        public ICommand SaveItemCommand => new Command(SaveItem);
        public TodoItemAdd()
        {
            InitializeComponent();
            this.BindingContext = new TodoItemViewModel();
        }

        private void SaveItem()
        {

        }

    }
}