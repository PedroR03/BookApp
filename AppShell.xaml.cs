using BookApp1.Views;

namespace BookApp1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        Routing.RegisterRoute(nameof(LogIn), typeof(LogIn));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(DetailsBookPage), typeof(DetailsBookPage));
        Routing.RegisterRoute(nameof(AuthorsPage), typeof(AuthorsPage));
    }
}
