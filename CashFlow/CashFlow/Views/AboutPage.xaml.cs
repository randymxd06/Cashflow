﻿using CashFlow.ViewModels;
using System;
using System.ComponentModel;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CashFlow.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            
            InitializeComponent();

            newAccountFrame.TranslateTo(600, 0);
            var AboutViewModel = new AboutViewModel();
            AboutViewModel.SetNavigation(DependencyService.Get<INavigation>());
            BindingContext = AboutViewModel;
        }
        private  void IrATabbedPage(object sender, EventArgs e)
        {
            //CashFlowTabbedPage tabbedPage = new CashFlowTabbedPage();
            // Agrega las páginas que deseas mostrar en el TabbedPage
            
           // await Navigation.PushAsync(new NavigationPage(tabbedPage));
        }




        private void showcrearCuenta_btn_Clicked(object sender, EventArgs e)
        {
            if (loginFrame != null)
            {

               
            }
        }

        private void btn_haveAccount_Clicked(object sender, EventArgs e)
        {
            if(loginFrame != null)
            {

                
            }
        }
    }
}