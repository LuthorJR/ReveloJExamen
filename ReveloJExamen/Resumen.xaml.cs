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
    public partial class Resumen : ContentPage
    {
        public Resumen()
        {
            InitializeComponent();

            string usercon = txtUsConec.Text;
            string shnomb = txtNombreUs.Text;
            string pagar = txtTotal.Text;

        }
    }
}