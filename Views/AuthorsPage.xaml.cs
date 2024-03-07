using BookApp1.ViewModels;

namespace BookApp1.Views;

public partial class AuthorsPage : ContentPage
{
    protected override void OnAppearing()
    {
        base.OnAppearing();
        ((AuthorsPageViewModel)BindingContext).AddBooks();
        ((AuthorsPageViewModel)BindingContext).FilterBooksDirector();
    }
    public AuthorsPage( AuthorsPageViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
	}
}