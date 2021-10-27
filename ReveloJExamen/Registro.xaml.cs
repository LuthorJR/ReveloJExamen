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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtInicial.Text))
                {
                var abono = double.Parse(txtInicial.Text);
                var diferencia = 1800 - abono;
                var cuota = (diferencia / 3)*1.05;
                txtMensual.Text = cuota.ToString();
            }
            else
                DisplayAlert("Error", "No se ha introducido datos", "ok");
            
        }
    }
}