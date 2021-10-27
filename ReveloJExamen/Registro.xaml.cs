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
            try{
                double matricula = Convert.ToDouble(txtInicial.Text);
                
                double cuotas = ((1800 - matricula)/3);
            }
            catch (Exception ex)
            {
               
            }
        }
    }
}