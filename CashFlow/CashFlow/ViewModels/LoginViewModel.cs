using CashFlow.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CashFlow.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {
        private INavigation Navigation { get; set; }
        private string eyeOn = "\uf208";
        private string eyeOff = "\uf209";
        public ICommand TogglePasswordCommand { get; }
        public Command LoginCommand { get; }
        public Command NewAccountCommand { get; }

        private bool isPassword;
        public bool IsPassword
        {
            get { return isPassword; }
            set
            {
                isPassword = value;
                OnPropertyChanged(nameof(IsPassword));
            }
        }

        private string passwordIcon;
        public string PasswordIcon
        {
            get { return passwordIcon; }
            set
            {
                passwordIcon = value;
                OnPropertyChanged(nameof(PasswordIcon));
            }
        }

        public LoginViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            PasswordIcon = eyeOff;
            IsPassword = true;
            TogglePasswordCommand = new Command(TogglePassword);
            LoginCommand = new Command(OnLoginClicked);
            NewAccountCommand = new Command(OnNewAccountBtnClicked);
        }
        private void TogglePassword()
        {
            if (PasswordIcon.Equals(eyeOff)){
                PasswordIcon=eyeOn;
            }else if (PasswordIcon.Equals(eyeOn)) {
                PasswordIcon = eyeOff;
            }
            IsPassword = !IsPassword;
        }

        public void SetNavigation(INavigation navigation)
        {
            Navigation = navigation;
        }

        private async void OnLoginClicked(object obj)
        {
            Debug.Write("Hola");
            await Navigation.PushAsync(new MainMenu());
            //await Application.Current.MainPage.Navigation.PushAsync(new MainMenu());
        }
        private async void OnNewAccountBtnClicked(object obj)
        {
            Debug.Write("New Account");
            await Navigation.PushModalAsync(new NewAccountPage());
            //await Application.Current.MainPage.Navigation.PushAsync(new NewAccountPage());
        }
    }
}
