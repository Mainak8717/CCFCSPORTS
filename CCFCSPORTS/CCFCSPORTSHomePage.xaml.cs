using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CCFCSPORTS
{
	public partial class CCFCSPORTSHomePage : ContentPage
	{
		public CCFCSPORTSHomePage()
		{
			InitializeComponent();
		}

		async void SportBtn_Clicked(object sender, System.EventArgs e)
		{
			Button button = sender as Button;
			if (button.Text.Equals("CRICKET"))
			{
				await Navigation.PushAsync(new CCFCSPORTSCategoryPage());
			}
			else if(button.Text.Equals("FOOTBALL"))
			{
			}
			else if (button.Text.Equals("RUGBY"))
			{
			}
	    }
	}
}
