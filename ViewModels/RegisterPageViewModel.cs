using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using BookApp1.Views;
using BookApp1.Models;

namespace BookApp1.ViewModels;

public partial class RegisterPageViewModel : ObservableObject
{
	public RegisterPageViewModel()
	{
        Current.Username = "user";
        Current.Password = "password";
        Current.Email = "email";
        Current.Id = 1;

    }

    [ObservableProperty]
    public User current = new User();

    [ObservableProperty]
    public string username;

    [ObservableProperty]
    public string password;

    [ObservableProperty]
    public string email;

    [RelayCommand]
    public async void Register()
    {
        await Shell.Current.GoToAsync("///" + nameof(LogIn));
    }
}