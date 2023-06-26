using CashFlow.Utils;
using CashFlow.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace CashFlow.ViewModels
{
   public class ProfileViewModel:BaseViewModel
    {
        public Command BeneficiaryPageCommand { get; }
        public Command NewProductPageCommand { get; }
        public ProfileViewModel()
        {

            BeneficiaryPageCommand = new Command(OnBeneficiaryClicked);
            NewProductPageCommand = new Command(OnNewProductClicked);
        }

        private async void OnBeneficiaryClicked(object obj)
        {
            await NavigationDispatcher.Instance.Navigation.PushAsync(new BeneficiaryPage());
            //await Application.Current.MainPage.Navigation.PushAsync(new MainMenu());
        }
        private async void OnNewProductClicked(object obj)
        {
            await NavigationDispatcher.Instance.Navigation.PushAsync(new ProductPage());
            //await Application.Current.MainPage.Navigation.PushAsync(new MainMenu());
        }
    }
}
