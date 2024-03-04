using PubMaui.ViewModels;

namespace PubMaui.Pages;

public partial class SignInPage : ContentPage
{
	public SignInPage(AuthViewModel authViewModel)
	{
		InitializeComponent();
        BindingContext = authViewModel;
	}

    

    private async void Signup_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SignUpPage));
    }
}