using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace curso11
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void btnMsg_Clicked(object sender, EventArgs e)
        {
            var res = await DisplayActionSheet("Colores", "Cancelar",  null, "Amarillo", "Rojo", "Azul");
            switch (res)
            {
                case "Amarillo":
                    fondo.BackgroundColor = Color.Yellow;
                    break;
                case "Rojo":
                    fondo.BackgroundColor = Color.Red;
                    break;
                case "Azul":
                    fondo.BackgroundColor = Color.Blue;
                    break;
                default:
                    fondo.BackgroundColor = Color.White;
                    break;

            }
        }
    }
}
