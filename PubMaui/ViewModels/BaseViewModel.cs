using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubMaui.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _isBusy;

        protected async Task GoToAsync(string url, bool animate = false) => 
            await Shell.Current.GoToAsync(url, animate);

        protected async Task DisplayErrorAlertAsync(string errorMessage) =>
            await Shell.Current.DisplayAlert("Error", errorMessage, "Ok");

        protected async Task DisplayAlertAsync(string message) =>
            await Shell.Current.DisplayAlert("Alert", message, "Ok");

    }
}
