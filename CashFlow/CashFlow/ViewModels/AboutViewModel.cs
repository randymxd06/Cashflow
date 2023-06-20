using CashFlow.Views;
using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CashFlow.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        private INavigation Navigation { get; set; }
        public AboutViewModel()
        {

            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            LoginCommand = new Command(OnLoginClicked);
        }

        public ICommand OpenWebCommand { get; }
        public void SetNavigation(INavigation navigation)
        {
            Navigation = navigation;
        }
       
        private async void OnLoginClicked(object obj)
        {
            Debug.Write("Hola");

            await Application.Current.MainPage.Navigation.PushAsync(new MainMenu());
        }
        
    }
}