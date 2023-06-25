using Microcharts;
using SkiaSharp;
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
    public partial class ProductDetailPage : ContentPage
    {

        private readonly ChartEntry[] entries = new[]
{
    new ChartEntry(10000)
    {
        Label = "Lunes",
        ValueLabel = "10,000",
        
        Color = SKColor.Parse("#910DC3") // Color rojo
    },
    new ChartEntry(11000)
    {
        Label = "Martes",
        ValueLabel = "11,000",
        Color = SKColor.Parse("#910DC3") // Color verde
    },
    new ChartEntry(9500)
    {
        Label = "Miércoles",
        ValueLabel = "9,500",
        Color = SKColor.Parse("#910DC3") // Color azul
    },
    new ChartEntry(12000)
    {
        Label = "Jueves",
        ValueLabel = "12,000",
        Color = SKColor.Parse("#910DC3") // Color naranja
    },
    new ChartEntry(10500)
    {
        Label = "Viernes",
        ValueLabel = "10,500",
        Color = SKColor.Parse("#910DC3") // Color púrpura
    }
};

        public ProductDetailPage()
        {
            InitializeComponent();
            chartViewBar.Chart = new LineChart
            {
                Entries = entries,
               ValueLabelOrientation = Orientation.Horizontal,
                LabelTextSize = 30,
                LabelColor= SKColor.Parse("#000000"),
                LabelOrientation = Orientation.Horizontal,
                PointMode = PointMode.Circle,
                PointSize = 27,
                LineSize=12,
                LineAreaAlpha = 1,
                BackgroundColor = SKColor.Parse("#ffffff")
            };
        }
    }
}