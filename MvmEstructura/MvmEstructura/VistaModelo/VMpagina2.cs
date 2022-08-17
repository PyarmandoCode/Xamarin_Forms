using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Windows.Input;
using MvmEstructura.Modelo;

namespace MvmEstructura.VistaModelo
{
    public class VMpagina2 : BaseViewModel
    {
        #region Variables
        string _Texto;
        public List<Discos> listadiscos { get; set; }
        #endregion
        #region Constructor
        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
            MostrarDiscos();
        }
        #endregion
        #region Objetos
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region Procesos
        public async Task Volver()

        {
            await Navigation.PopAsync();
        }

        public async Task Alerta(Discos parametros)

        {
            await DisplayAlert("Titulo", parametros.nombre, "Ok");
        }


        public void MostrarDiscos()
        {
            listadiscos=new List<Discos>()
            {
                new Discos
                {
                    nombre="Soda Stereo",
                    imagen= "https://res.cloudinary.com/dream-music/image/upload/v1623122104/album/soda_stereo_album_lee7pa.jpg"
                },

                new Discos
                {
                    nombre = "Chezina",
                    imagen = "https://res.cloudinary.com/dream-music/image/upload/v1623122101/album/mitrayectoria_ovnom3.jpg"
                },

                 new Discos
                 {
                     nombre = "Bacilos",
                     imagen = "https://res.cloudinary.com/dream-music/image/upload/v1623122101/album/lomejordebacilos_b7eore.jpg"
                 },
               

            };

        }
        #endregion
        #region Comandos
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand Alertacommand => new Command<Discos>(async (p) => await Alerta(p));
        //public ICommand ProcesoSimplecommand => new Command(ProcesoSimple);
        #endregion

    }
}
