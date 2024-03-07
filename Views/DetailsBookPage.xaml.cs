using BookApp1.ViewModels;

namespace BookApp1.Views;

public partial class DetailsBookPage : ContentPage
{
	public DetailsBookPage(DetailsBookPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}