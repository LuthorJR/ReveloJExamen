using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReveloJExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnRegistro_Clicked(object sender, EventArgs e)
        {
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;

               if ((usuario == "estudiante2021") && (clave == "uisrael2021"))
               {
                   await Navigation.PushAsync(new Registro());
                }
            
              else{
                 lblMensaje.Text = "El usuario o la clave son incorrectos";
              }

        }
    }
}