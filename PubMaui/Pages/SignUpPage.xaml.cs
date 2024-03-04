using PubMaui.ViewModels;

namespace PubMaui.Pages;

public partial class SignUpPage : ContentPage
{
	public SignUpPage(AuthViewModel authViewModel)
	{
		InitializeComponent();
		BindingContext = authViewModel;
		
	}

    

    private async void Signin_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SignInPage));
    }
}