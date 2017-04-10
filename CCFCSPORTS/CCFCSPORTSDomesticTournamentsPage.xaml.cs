using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace CCFCSPORTS
{
	public partial class CCFCSPORTSDomesticTournamentsPage : ContentPage
	{
		public ObservableCollection<WeekendFootballGames> weekendFootballGames { get; set; }

		public CCFCSPORTSDomesticTournamentsPage()
		{
			InitializeComponent();
			weekendFootballGames = new ObservableCollection<WeekendFootballGames> ();
			weekendFootballGames.Add (new WeekendFootballGames{ TeamOne="CCFC A", TeamTwo="ARMY", gameTime = DateTime.Now, result ="CCFC - A Won",TeamOneScore = "2", TeamTwoScore = "1"});
			weekendFootballGames.Add (new WeekendFootballGames{ TeamOne="CCFC A", TeamTwo="XAVIERS", gameTime = DateTime.Now, result ="CCFC - A Won",TeamOneScore = "2", TeamTwoScore = "1"});
			weekendFootballGames.Add (new WeekendFootballGames{ TeamOne="CCFC A", TeamTwo="CCFC - B", gameTime = DateTime.Now, result ="CCFC - A Won",TeamOneScore = "2", TeamTwoScore = "1"});
            lstView.ItemsSource = weekendFootballGames;
		}
	}
}
