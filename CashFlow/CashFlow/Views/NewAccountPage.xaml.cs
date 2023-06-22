using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CashFlow.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewAccountPage : ContentPage
    {
        public int pasos = 1;
        public NewAccountPage()
        {
            InitializeComponent();
        }
       
    }
}