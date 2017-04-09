using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CCFCSPORTS
{
	public partial class CCFCSPORTSCategoryPage : ContentPage
	{
		public CCFCSPORTSCategoryPage()
		{
			InitializeComponent();
			this.Title = "CRICKET";
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new CCFCSPORTSTournamentPage());
		}
	}
}
