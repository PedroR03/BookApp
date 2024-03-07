using BookApp1.ViewModels;

namespace BookApp1.Views;

public partial class LogIn : ContentPage
{
    public LogIn(LoginViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

}