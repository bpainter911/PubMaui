using PubMaui.ViewModels;

namespace PubMaui.Pages;

public partial class SignUpPage : ContentPage
{
	public SignUpPage(AuthViewModel authViewModel)
	{
		InitializeComponent();
		BindingContext = authViewModel;
		
	}

    private async void GotoHome_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }

    private async void SigninLable_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SignInPage));
    }
}