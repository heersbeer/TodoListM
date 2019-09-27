using System;
using System.Collections.Generic;
using System.ComponentModel;
using TodoListM.ViewModels;
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
    }
}
