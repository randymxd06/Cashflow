using CashFlow.Utils;
using CashFlow.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CashFlow.DesignTemplates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductoFrameTemplate : Frame
    {
        public ProductoFrameTemplate()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await NavigationDispatcher.Instance.Navigation.PushAsync(new ProductDetailPage());
        }
    }
}