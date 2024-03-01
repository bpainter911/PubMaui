namespace PubMaui.Pages;

public partial class OnBoardingPage : ContentPage
{
	public OnBoardingPage()
	{
		InitializeComponent();
	}

  //  private async void Button_Clicked(object sender, EventArgs e)
  //  {
		//await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
  //  }

    private async void SignIn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SignInPage));
    }

    private async void SignUp_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SignUpPage));
    }
}