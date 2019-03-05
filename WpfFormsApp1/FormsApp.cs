using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WpfFormsApp1
{
	class FormsApp : Xamarin.Forms.Application
	{
		public FormsApp()
		{
			MainPage = new ContentPage
			{
				Content = new Label
				{
					Text = "Hello Xamarin.Forms!",
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center
				}
			};
		}
	}
}
