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

            btnPage2.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Segunda("Jose","Perez"));
            };


            btnPage3.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Tercera());
            };


            

        }

        //private async void btnMsg_Clicked(object sender, EventArgs e)
        //{
        //    await DisplayAlert("Tapped! was tapped.", "OK", "Cancel");
        //}

   

    
	}

}
