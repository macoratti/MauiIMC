using MauiIMC.Mvvm.Views;

namespace MauiIMC;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new ImcView());
	}
}
