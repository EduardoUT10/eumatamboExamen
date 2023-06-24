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
    public partial class Resumen : ContentPage
    {
        double montoInicial;
        double PagoMensual;
        public Resumen(string usuario, string apellido, string edad, string fecha, string ciudad, string pais, string montoInicial, string pagoMensual)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            txtNombre.Text = usuario;
            txtApellido.Text = apellido;
            txtEdad.Text = edad;
            txtFecha.Text = fecha;
            txtCiudad.Text = ciudad;
            txtPais.Text = pais;
            txtMontoInicial.Text = montoInicial;
            txtPagoMensual.Text = pagoMensual;
            this.montoInicial = Convert.ToDouble(montoInicial);
            this.PagoMensual = Convert.ToDouble(pagoMensual);
            txtPagoTotal.Text = (this.PagoMensual * 4).ToString();
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Login());
        }
    }
}