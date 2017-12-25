using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace curso5_controles_basicos
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
 

        private void btnMostrar_Clicked_1(object sender, EventArgs e)
        {
            lblResultado.Text = "Bienvenido al Sistema " + txtNom.Text;
            txtNom.Text = "";


        }
    }
}
