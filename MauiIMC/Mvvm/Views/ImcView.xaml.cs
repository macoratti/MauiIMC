using MauiIMC.Mvvm.ViewModels;

namespace MauiIMC.Mvvm.Views;

public partial class ImcView : ContentPage
{
	public ImcView()
	{
		InitializeComponent();
		BindingContext = new ImcViewModel();
	}
}