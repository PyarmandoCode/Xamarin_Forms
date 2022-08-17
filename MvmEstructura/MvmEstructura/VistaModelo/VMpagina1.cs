using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Windows.Input;
using MvmEstructura.Vistas;

namespace MvmEstructura.VistaModelo
{
    public class VMpagina1:BaseViewModel
    {
        #region Variables
        //string _Texto;
        string _numero1;
        string _numero2;
        string _respuesta;
        string _cmbcombo;
        
        #endregion
        #region Constructor
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Objetos
        public string Numero1
        {
            get { return _numero1; }
            set { SetValue(ref _numero1, value); }
        }

        public string Numero2
        {
            get { return _numero2; }
            set { SetValue(ref _numero2, value); }
        }

        public string Respuesta
        {
            get { return _respuesta; }
            set { SetValue(ref _respuesta, value); }
        }

        public string Combo
        {
            get { return _cmbcombo; }
            set { SetValue(ref _cmbcombo, value); }
        }

        public string SeleccionarCombo
        {
            get { return _cmbcombo; }
            //para tomar el valor del combo
            set
            {
                SetProperty(ref _cmbcombo, value);
                Combo = _cmbcombo;
            }
        }

        #endregion
        #region Procesos
        public async Task Alerta()
        {
            await DisplayAlert("Titulo", "Bienvenido al Patron MVVM", "OK");
        }

        public async Task resultado()
        {
            int numero1;
            int numero2;
            int res;
            numero1 = Convert.ToInt16(_numero1);
            numero2 = Convert.ToInt16(_numero2);
            res = numero1 + numero2;
            Respuesta = res.ToString();
            await DisplayAlert("Titulo", res.ToString(), "OK");
        }

        public async Task ValorCombo()
        {
            await DisplayAlert("Valor Seleccionado del Combo", Combo, "OK");
        }

        public async Task ir_pagina_2()
        {
            await Navigation.PushAsync(new Pagina2());
        }


        public void ProcesoSimple()
        {

        }
        #endregion
        #region Comandos
        public ICommand Alertcommand=> new Command(async () => await Alerta());
        public ICommand Proceso_Arit_Command => new Command(async () => await resultado());
        public ICommand ProcesoSimplecommand => new Command(ProcesoSimple);

        public ICommand ir_pagina2_Command => new Command(async () => await ir_pagina_2());

        public ICommand Combocommand => new Command(async () => await ValorCombo());
        #endregion

    }
}

