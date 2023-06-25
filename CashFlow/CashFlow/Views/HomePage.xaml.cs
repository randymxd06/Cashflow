using CashFlow.DesignTemplates;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CashFlow.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            GenerateFramesAsync();
           
        }

        private async void GenerateFramesAsync()
        {
            try
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < 5; i++)
                    {
                        ProductoFrameTemplate customFrame = new ProductoFrameTemplate();

                        Label productoLabel = customFrame.FindByName<Label>("producto_label");
                        Label balanceLabel = customFrame.FindByName<Label>("balance");

                        // Establecer los valores de los elementos de etiqueta
                        productoLabel.Text = "Cuenta de ahorros / 45454040405";
                        balanceLabel.Text = "Balance: $-10,000.00";

                        // Agregar el Frame a algún contenedor en tu diseño
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            layout_productos.Children.Add(customFrame);
                        });
                    }
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex);
            }
        }
    }
}