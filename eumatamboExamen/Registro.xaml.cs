using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eumatamboExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {   string usuario;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario Conectado: " + usuario;
            this.usuario = usuario;
        }

        private void btnPagoMensual_Clicked(object sender, EventArgs e)
        {
            double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
            double Mensual;
            double fijo;
            fijo = (1500 - montoInicial) / 4;

            Mensual = fijo + (fijo * 0.04);
            txtMontoMensual.Text = Mensual.ToString();
        }

        private void txtMontoInicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
              double dato = Convert.ToDouble(txtMontoInicial);
              if (dato > 100 || dato < 1500)
            {
                 DisplayAlert("Error", "El monto debe ser mayor de 100 y menor de 1500", "Cerrar");
                   txtMontoInicial.Text = "";
               }
            }
            catch (Exception) { }
        }
    }
    }
