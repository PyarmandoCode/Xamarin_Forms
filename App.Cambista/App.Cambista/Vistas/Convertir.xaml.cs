using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Cambista.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        public Convertir()
        {
            InitializeComponent();
        }

        private void btnvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            validar();
        }
        private void Calcular()
        {
            double cm1;
            double m1;
            cm1 = Convert.ToDouble(txtsoles.Text);
            m1 = cm1 / 3.83;
            lblresultado.Text="$/." +m1.ToString();

        }
        private void validar()
        {
            if (!string.IsNullOrEmpty(txtsoles.Text))
            {
                Calcular();
            }
            else
            {
                DisplayAlert("Error", "Ingrese Soles", "Ok");
            }
        }
    }
}