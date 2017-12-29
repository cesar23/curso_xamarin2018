using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            //InitializeComponent();
            var listView = new ListView
            {
                RowHeight = 40
            };
    //        listView.ItemsSource = new string[]
    //        {
    //"Buy pears", "Buy oranges", "Buy mangos", "Buy apples", "Buy bananas"
    //        };


            listView.ItemsSource = new TodoItem[] {
    new TodoItem { Name = "Buy pears" },
    new TodoItem { Name = "Buy oranges", Done=true} ,
    new TodoItem { Name = "Buy mangos" },
    new TodoItem { Name = "Buy apples", Done=true },
    new TodoItem { Name = "Buy bananas", Done=true }
};

            listView.ItemSelected += async (sender, e) => {
                await DisplayAlert("Tapped!", e.SelectedItem + " was tapped.", "OK");
            };


            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { listView }
            };
        }
	}

    public class TodoItem
    {
        public string Name { get; set; }
        public bool Done { get; set; }
    }
}
