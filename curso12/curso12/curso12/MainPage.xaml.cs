using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace curso12
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        //private async void btnMsg_Clicked(object sender, EventArgs e)
        //{
        //    await DisplayAlert("Tapped! was tapped.", "OK", "Cancel");
        //}

        public void changebtn()
        {
            lblcc.Text = "fff";
        }

    
	}

}
