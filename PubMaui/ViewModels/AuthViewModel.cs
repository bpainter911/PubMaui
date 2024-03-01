using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PubMaui.Pages;
using PubMaui.Services;
using PubMaui.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubMaui.ViewModels
{
    public partial class AuthViewModel(IAuthApi authApi) : BaseViewModel
    {
        private readonly IAuthApi _authApi = authApi;
        [ObservableProperty, NotifyPropertyChangedFor(nameof(CanSignup))]
        private string? _firstName;
        [ObservableProperty, NotifyPropertyChangedFor(nameof(CanSignup))]
        private string? _lastName;
        [ObservableProperty, NotifyPropertyChangedFor(nameof(CanSignup)), NotifyPropertyChangedFor(nameof(CanSignin))]
        private string? _email;
        [ObservableProperty, NotifyPropertyChangedFor(nameof(CanSignup)), NotifyPropertyChangedFor(nameof(CanSignin))]
        private string? _password;
        [ObservableProperty, NotifyPropertyChangedFor(nameof(CanSignup))]
        private string? _address;
        [ObservableProperty, NotifyPropertyChangedFor(nameof(CanSignup))]
        private string? _fullName;
        [ObservableProperty, NotifyPropertyChangedFor(nameof(CanSignup))]
        private string? _phNumber;
        [ObservableProperty, NotifyPropertyChangedFor(nameof(CanSignup))]
        private string? _postalCode;
        [ObservableProperty, NotifyPropertyChangedFor(nameof(CanSignup))]
        private string? _cityTown;

        public bool CanSignup => !string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password);

        public bool CanSignin => !string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password);

        

        [RelayCommand]
        private async Task SignupAsync()
        {
            IsBusy = true;

            try
            {
                var fullName = _firstName + " " + _lastName;
                FullName = fullName;
                var signupDto = new SignupRequestDto(FirstName, LastName, FullName, Email, Password, PhNumber, Address, CityTown,PostalCode);
                // Make API Call
                var result =  await _authApi.SignupAsync(signupDto);

                if(result.IsSuccess)
                {
                    await DisplayAlertAsync(result.Data.token);
                    // Navigate to home page
                    await GoToAsync($"//{nameof(HomePage)}", animate:true) ;
                    
                }
                else
                {
                    //Display error
                    await DisplayErrorAlertAsync(result.ErrorMessage ?? "Unknown error in signing up");
                }

            }
            catch (Exception ex)
            {

                await DisplayErrorAlertAsync(ex.Message);
            }
            finally
            { 
                IsBusy = false; 
            }

        }

        [RelayCommand]
        private async Task SigninAsync()
        {
            IsBusy = true;

            try
            {
                
                
                var signinDto = new SigninRequestDto(Email, Password);
                // Make API Call
                var result = await _authApi.SigninAsync(signinDto);

                if (result.IsSuccess)
                {
                    await DisplayAlertAsync(result.Data.User.FullName);
                    // Navigate to home page
                    await GoToAsync($"//{nameof(HomePage)}", animate: true);

                }
                else
                {
                    //Display error
                    await DisplayErrorAlertAsync(result.ErrorMessage ?? "Unknown error in signing in");
                }

            }
            catch (Exception ex)
            {

                await DisplayErrorAlertAsync(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }

        }
    }
}
