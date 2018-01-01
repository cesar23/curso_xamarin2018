using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace curso12
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Segunda : ContentPage
	{
		public Segunda (String nombre,String apellido)
		{
			InitializeComponent ();
            lblNombre.Text = nombre;
            lblApellido.Text = apellido;

        }
	}
}