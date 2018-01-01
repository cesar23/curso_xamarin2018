using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace curso14_MasteDetail
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : ContentPage
	{
		public Master ()
		{
			InitializeComponent ();

            //btnPrimera.Clicked += (sender, e) =>
            //{
            //    App.MasterD.IsPresented = false;
            //    await App.MasterD.Detail.Navigation
            //};

            //btnSegundo.Clicked += (sender, e) =>
            //{
            //    App.MasterD.IsPresented = false;
            //};

        }

        private async void BtnPrimera_Click(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new Primera());
            // await DisplayAlert("Alert", "You have been alerted", "OK");

        }
        private async void BtnSegunda_Click(object sender, EventArgs e)
        {

            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new Segunda());

        }

    }
}