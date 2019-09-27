using System;
using System.Collections.Generic;
using System.ComponentModel;
using TodoListM.Models;
using TodoListM.ViewModels;
using TodoListM.Views;
using Xamarin.Forms;

namespace TodoListM
{
        
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainViewModel();
        }
        async private void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            TodoItem tappedItem = e.Item as TodoItem;
            await Navigation.PushAsync(new TodoItemView(tappedItem));
        }
        async public void AddItem(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TodoItemView(new TodoItem {}));

        }
    }
}
