using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PaulNsemana1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Btnbienvenida_Clicked(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string edad = txtedad.Text;
            DisplayAlert("Mensaje de Bienvenida", "Bienvenido: Tu nombre es " + nombre + " tu apellido es " + apellido + " y tienes " + edad + " años", "Cerrar");
        }
    }
}
