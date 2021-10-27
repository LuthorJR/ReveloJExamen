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
            var abono = double.Parse(txtInicial.Text);
            var diferencia = 1800 - abono;
            var cuota = diferencia / 3;
            txtMensual.Text = cuota.ToString();

            
        }
    }
}