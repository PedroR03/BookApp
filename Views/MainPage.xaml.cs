using BookApp1.ViewModels;

namespace BookApp1.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;

    }
}