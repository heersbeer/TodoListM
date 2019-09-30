using System.Windows.Input;
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
        }

        private void SaveItem()
        {

        }

    }
}