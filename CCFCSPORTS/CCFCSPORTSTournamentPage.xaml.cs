using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CCFCSPORTS
{
	public partial class CCFCSPORTSTournamentPage : ContentPage
	{
		public CCFCSPORTSTournamentPage()
		{
			InitializeComponent();
			this.Title = "TOURNAMENTS";
		}
		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new CCFCSPORTSDomesticTournamentsPage());
		}
	}
}
