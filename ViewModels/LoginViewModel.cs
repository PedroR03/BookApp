using BookApp1.Views;
using BookApp1.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BookApp1.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    public LoginViewModel()
    {
        Current.Username = "user";
        Current.Password = "password";
        Current.Id = 1;

    }

    [ObservableProperty]
    public User current = new User();

    [ObservableProperty]
    public string username;

    [ObservableProperty]
    public string password;

    [RelayCommand]
    public async void Login()
    {
        //await Shell.Current.DisplayAlert("", $"{Username}", "ok");

        // check the user name and password
        // if  current.username == username and password == current.password




        await Shell.Current.GoToAsync(nameof(MainPage));
    }

    [RelayCommand]
    public async void Register()
    {
        //await Shell.Current.DisplayAlert("", $"{Username}", "ok");

        // check the user name and password
        // if  current.username == username and password == current.password




        await Shell.Current.GoToAsync(nameof(RegisterPage));
    }
    // all other functuions get written outside

    // to
}