using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;

using SpeedwayBetting.Helpers;
using SpeedwayBetting.Models;
using SpeedwayBetting.Views;

namespace SpeedwayBetting.ViewModels
{
    class AddMatchViewModel : BaseViewModel
    {
        public AddMatchViewModel()
        {
            TeamsList = new List<string>();
            TeamsList.Add("Stal Gorzów");
            TeamsList.Add("Falubaz Zielona Góra");
            TeamsList.Add("KS Toruń");
            TeamsList.Add("Sparta Wrocław");
            TeamsList.Add("GKM Grudziądz");
            TeamsList.Add("Unia Leszno");
            TeamsList.Add("Włókniarz Częstochowa");
            TeamsList.Add("ROW Rybnik");

            Match = new tblMatches();
        }

        private List<string> teamsList;

        public List<string> TeamsList
        {
            get { return teamsList; }
            set
            {
                teamsList = value;
                RaisePropertyChanged();
            }
        }

        private tblMatches match;

        public tblMatches Match
        {
            get { return match; }
            set
            {
                match = value;
                RaisePropertyChanged();
            }
        }

        public ICommand AddMatchCommand { get { return new DelegateCommand(AddMatch); } }

        private void AddMatch()
        {
            dbOperations.CreateMatch(Match);
            MessageBox.Show("Match added");
        }
    }
}
