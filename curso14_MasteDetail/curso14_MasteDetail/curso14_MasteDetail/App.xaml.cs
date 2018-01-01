﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace curso14_MasteDetail
{
	public partial class App : Application
	{
        public static MasterDetailPage MasterD { get; set; }

		public App ()
		{
			InitializeComponent();

			MainPage = new curso14_MasteDetail.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
