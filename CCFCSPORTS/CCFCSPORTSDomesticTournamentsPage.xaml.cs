using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace CCFCSPORTS
{
	public partial class CCFCSPORTSDomesticTournamentsPage : ContentPage
	{
		public ObservableCollection<GroupedWeekendFootballGame> grouped { get; set; }

		public CCFCSPORTSDomesticTournamentsPage()
		{
			InitializeComponent();
			B_Line.IsVisible = false;
			C_Line.IsVisible = false;

string json = @"{
  ""users"": [
    {
      ""id"": 0,
      ""name"": ""Adam Carter"",
      ""work"": ""Unilogic"",
      ""email"": ""adam.carter@unilogic.com"",
      ""dob"": ""1978"",
      ""address"": ""83 Warner Street"",
      ""city"": ""Boston"",
      ""optedin"": true
    },
    {
      ""id"": 1,
      ""name"": ""Leanne Brier"",
      ""work"": ""Connic"",
      ""email"": ""leanne.brier@connic.org"",
      ""dob"": ""13/05/1987"",
      ""address"": ""9 Coleman Avenue"",
      ""city"": ""Toronto"",
      ""optedin"": false
    }
  ]
}";
			var bob = JObject.Parse(json);
			Debug.WriteLine ("{0} with {1} hair", bob["users"][0], bob["HairColor"]);


			grouped = new ObservableCollection<GroupedWeekendFootballGame>();
			var grroup1 = new GroupedWeekendFootballGame() { LongName = "21st April, 2017", ShortName = "v" };
			grroup1.Add(new WeekendFootballGames { TeamOne = "CCFC A", TeamTwo = "ARMY", gameTime = DateTime.Now, result = "CCFC - A Won", TeamOneScore = "2", TeamTwoScore = "1" });
			grroup1.Add(new WeekendFootballGames { TeamOne = "CCFC A", TeamTwo = "XAVIERS", gameTime = DateTime.Now, result = "CCFC - A Won", TeamOneScore = "2", TeamTwoScore = "1" });
			grroup1.Add(new WeekendFootballGames { TeamOne = "CCFC A", TeamTwo = "CCFC - B", gameTime = DateTime.Now, result = "CCFC - A Won", TeamOneScore = "2", TeamTwoScore = "1" });
			grouped.Add(grroup1);

			var grroup2 = new GroupedWeekendFootballGame() { LongName = "28th April, 2017", ShortName = "v" };
			grroup2.Add(new WeekendFootballGames { TeamOne = "CCFC A", TeamTwo = "ARMY", gameTime = DateTime.Now, result = "CCFC - A Won", TeamOneScore = "2", TeamTwoScore = "1" });
			grroup2.Add(new WeekendFootballGames { TeamOne = "CCFC A", TeamTwo = "XAVIERS", gameTime = DateTime.Now, result = "CCFC - A Won", TeamOneScore = "2", TeamTwoScore = "1" });
			grroup2.Add(new WeekendFootballGames { TeamOne = "CCFC A", TeamTwo = "CCFC - B", gameTime = DateTime.Now, result = "CCFC - A Won", TeamOneScore = "2", TeamTwoScore = "1" });
			grouped.Add(grroup2);

			var grroup3 = new GroupedWeekendFootballGame() { LongName = "5th May, 2017", ShortName = "v" };
			grroup3.Add(new WeekendFootballGames { TeamOne = "CCFC A", TeamTwo = "ARMY", gameTime = DateTime.Now, result = "CCFC - A Won", TeamOneScore = "2", TeamTwoScore = "1" });
			grroup3.Add(new WeekendFootballGames { TeamOne = "CCFC A", TeamTwo = "XAVIERS", gameTime = DateTime.Now, result = "CCFC - A Won", TeamOneScore = "2", TeamTwoScore = "1" });
			grroup3.Add(new WeekendFootballGames { TeamOne = "CCFC A", TeamTwo = "CCFC - B", gameTime = DateTime.Now, result = "CCFC - A Won", TeamOneScore = "2", TeamTwoScore = "1" });
			grouped.Add(grroup3);

			lstView.ItemsSource = grouped;
		}

		void A_ButtonClicked(object sender, System.EventArgs e)
		{
			A_Line.IsVisible = true;
			B_Line.IsVisible = false;
			C_Line.IsVisible = false;
		
		}
		void B_ButtonClicked(object sender, System.EventArgs e)
		{
			A_Line.IsVisible = false;
			B_Line.IsVisible = true;
			C_Line.IsVisible = false;
		}
		void C_ButtonClicked(object sender, System.EventArgs e)
		{
			A_Line.IsVisible = false;
			B_Line.IsVisible = false;
			C_Line.IsVisible = true;
		}

		public class GroupedWeekendFootballGame : ObservableCollection<WeekendFootballGames>
		{
			public string LongName { get; set; }
			public string ShortName { get; set; }
		}
	}
}