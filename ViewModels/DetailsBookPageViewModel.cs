using BookApp1.Models;
using BookApp1.ViewModels;
using BookApp1.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BookApp1.ViewModels;

[QueryProperty("CurrentBook", "CurrentBook")]
public partial class DetailsBookPageViewModel : ObservableObject
{
	public DetailsBookPageViewModel()
	{

	}

	[ObservableProperty]
	Book currentBook;


	[RelayCommand]

	public async void BackToMainPage()
	{
		await Shell.Current.GoToAsync(nameof(MainPage));
	}
}