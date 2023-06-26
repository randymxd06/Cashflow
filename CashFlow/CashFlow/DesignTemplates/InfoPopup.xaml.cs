using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CashFlow.DesignTemplates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPopup : Popup
    {
        public InfoPopup(string _tipo,string _titulo, string _contenido,  Action  okAction, Action cancelAction)
        {
            InitializeComponent();
            Application.Current.Resources.TryGetValue("BrightYarrow", out var WarningColor);
            Application.Current.Resources.TryGetValue("ChiGong", out var ErrorColor);
            Application.Current.Resources.TryGetValue("MintLeaf", out var SuccessColor);

            switch (_tipo)
            {
                case "success":
                    icono_success.IsVisible = true;
                    icono_error.IsVisible = false;
                    icono_warning.IsVisible = false;
                    btnOk.BackgroundColor = (Color)SuccessColor;
                    layoutInfo.BackgroundColor = (Color)SuccessColor;
                    btnCancel.IsVisible= false;
                    break;
                case "warning":
                    icono_success.IsVisible = false;
                    icono_error.IsVisible = false;
                    icono_warning.IsVisible = true;
                    btnOk.BackgroundColor = (Color)WarningColor;
                    layoutInfo.BackgroundColor = (Color)WarningColor;
                    btnCancel.IsVisible = true;
                    btnCancel.BackgroundColor = (Color)SuccessColor;
                    break;
                case "error":
                    icono_success.IsVisible = false;
                    icono_error.IsVisible = true;
                    icono_warning.IsVisible = false;
                    btnOk.BackgroundColor = (Color)ErrorColor;
                    layoutInfo.BackgroundColor = (Color)ErrorColor;
                    btnCancel.IsVisible = false;
                    btnOk.Text = "Atras";
                    break;
            };

            titulo.Text = _titulo;
            mensaje.Text= _contenido;

            btnOk.Clicked +=  (sender, e) => {
                 okAction?.Invoke();
                Dismiss(null);
            };
            btnCancel.Clicked += (sender, e) =>
            {
                cancelAction?.Invoke();
                Dismiss(null);
            };

        }
        public void OkAction(System.Object sender, System.EventArgs e)
        {
            Dismiss(null);
            
        }

    }
}