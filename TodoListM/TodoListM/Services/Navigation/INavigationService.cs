﻿using System;
using System.Threading.Tasks;
using TodoListM.ViewModels.Base;

namespace TodoListM.Services.Navigation
{
    public interface INavigationService
    {
        ViewModelBase PreviousPageViewModel { get; }

        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;

        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;

        Task RemoveLastFromBackStackAsync();

        Task RemoveBackStackAsync();
    }
}
