using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace curso9_DisplayAlert
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void btnMsg_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje", "Mensaje de prueba", "Cancelar");
        }

        private async void btnMsg2_Clicked(object sender, EventArgs e)
        {
            bool res = await DisplayAlert("Mensaje", "Cambiar color","Aceptar", "Cancelar");

            if (res == true)
                fondo.BackgroundColor = Color.Yellow;
            else
                fondo.BackgroundColor = Color.White;
        }
    }
}
