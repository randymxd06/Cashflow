using CashFlow.Resources.Styles;
using CashFlow.Views;
using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace CashFlow.ViewModels
{
    public class NewAccountViewModel : BaseViewModel
    {
        

        private int pasos;
        public int Pasos
        {
            get { return pasos; }
            set
            {
                pasos = value;
                UpdateButtonProperties();
                OnPropertyChanged(nameof(Pasos));
            }
        }

        private string buttonText;
        public string ButtonText
        {
            get { return buttonText; }
            set
            {
                buttonText = value;
                OnPropertyChanged(nameof(ButtonText));
            }
        }

        private Color buttonColor;
        public Color ButtonColor
        {
            get { return buttonColor; }
            set
            {
                buttonColor = value;
                OnPropertyChanged(nameof(ButtonColor));
            }
        }

        //configuracion del voton siguiente//Terminar registro
        private string sgtButtonText;
        public string SgtButtonText
        {
            get { return sgtButtonText; }
            set
            {
                sgtButtonText = value;
                OnPropertyChanged(nameof(SgtButtonText));
            }
        }

        private Color sgtbuttonColor;
        public Color SgtButtonColor
        {
            get { return sgtbuttonColor; }
            set
            {
                sgtbuttonColor = value;
                OnPropertyChanged(nameof(SgtButtonColor));
            }
        }

        private Color step1Color;
        public Color Step1Color
        {
            get { return step1Color; }
            set
            {
                step1Color = value;
                OnPropertyChanged(nameof(Step1Color));
            }
        }
        private Color step2Color;
        public Color Step2Color
        {
            get { return step2Color; }
            set
            {
                step2Color = value;
                OnPropertyChanged(nameof(Step2Color));
            }
        }
        private Color step3Color;
        public Color Step3Color
        {
            get { return step3Color; }
            set
            {
                step3Color = value;
                OnPropertyChanged(nameof(Step3Color));
            }
        }

        private bool isStackLayout1Visible;
        public bool IsStackLayout1Visible
        {
            get { return isStackLayout1Visible; }
            set
            {
                isStackLayout1Visible = value;
                OnPropertyChanged(nameof(IsStackLayout1Visible));
            }
        }

        private bool isStackLayout2Visible;
        public bool IsStackLayout2Visible
        {
            get { return isStackLayout2Visible; }
            set
            {
                isStackLayout2Visible = value;
                OnPropertyChanged(nameof(IsStackLayout2Visible));
            }
        }
        private bool isStackLayout3Visible;
        public bool IsStackLayout3Visible
        {
            get { return isStackLayout3Visible; }
            set
            {
                isStackLayout3Visible = value;
                OnPropertyChanged(nameof(IsStackLayout3Visible));
            }
        }

        public event EventHandler<string> DisplayAlertRequested;

        private void MostrarAlerta()
        {
            // Disparar el evento para solicitar la visualización de una alerta
            DisplayAlertRequested?.Invoke(this, "Mensaje de alerta");
        }

        public ICommand IncreasePasosCommand { get; }
        public ICommand DecreasePasosCommand { get; }

        public NewAccountViewModel()
        {
            Pasos = 1; // Valor inicial de pasos
            IncreasePasosCommand = new Command(IncreasePasos);
            DecreasePasosCommand = new Command(DecreasePasos);
        }

        private void UpdateButtonProperties()
        {
            if (Pasos == 1)
            {
                Step1Color = Color.Orange;
                Step2Color = Color.Gray;
                Step3Color = Color.Gray;
                ButtonText = "Cancelar";
                SgtButtonText = "Siguiente";
                Debug.WriteLine(Application.Current.Resources.Values);
                ButtonColor = Color.FromHex("F3905A");
                SgtButtonColor = Color.Blue;

                IsStackLayout1Visible = true;
                IsStackLayout2Visible = false;
                IsStackLayout3Visible = false;
            }
            else if (Pasos == 2) 
            {
                Step1Color = Color.LightGreen;
                Step2Color = Color.Orange;
                Step3Color = Color.Gray;


                SgtButtonText = "Siguiente";
                ButtonText = "Atras";
                ButtonColor = Color.Blue;
                SgtButtonColor = Color.Blue;

                IsStackLayout1Visible = false;
                IsStackLayout2Visible = true;
                IsStackLayout3Visible = false;
            }
            else  if(Pasos == 3) {
                Step1Color = Color.LightGreen;
                Step2Color = Color.LightGreen;
                Step3Color = Color.Orange;
                SgtButtonText = "Completar Registro";
                SgtButtonColor = Color.Green;

                IsStackLayout1Visible = false;
                IsStackLayout2Visible = false;
                IsStackLayout3Visible = true;
            }
        }
        private void IncreasePasos()
        {
            if (Pasos < 3)
            {
                Pasos++;
            }
        }

        private void DecreasePasos()
        {
            if (Pasos > 1)
            {
                Pasos--;
            }
        }
    }

}
