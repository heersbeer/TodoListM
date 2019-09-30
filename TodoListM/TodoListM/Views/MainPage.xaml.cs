using System;
using TodoListM.Models;
using TodoListM.Views;
using Xamarin.Forms;

namespace TodoListM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Console.WriteLine("Mainpage View");
        }
        async private void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            TodoItem tappedItem = e.Item as TodoItem;
            await Navigation.PushAsync(new TodoItemEdit(tappedItem));
        }

    }
}
