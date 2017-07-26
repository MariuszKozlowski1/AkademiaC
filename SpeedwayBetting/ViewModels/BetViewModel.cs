using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

using SpeedwayBetting.Helpers;
using SpeedwayBetting.Models;
using SpeedwayBetting.Views;


namespace SpeedwayBetting.ViewModels
{
    class BetViewModel : BaseViewModel
    {
        public BetViewModel()
        {
            BetList = new List<string>();
            for (int i = 15; i < 76; i++)
            {
                BetList.Add((90 - i).ToString() + ":" + i);
            }
            MatchList = dbOperations.ReadMatchList();
        }

        private ObservableCollection<tblMatches> matchList;

        public ObservableCollection<tblMatches> MatchList
        {
            get { return matchList; }
            set
            {
                matchList = value;
                RaisePropertyChanged();
            }
        }

        private tblMatches selectedMatch;

        public tblMatches SelectedMatch
        {
            get { return selectedMatch; }
            set
            {
                selectedMatch = value;
                RaisePropertyChanged();
            }
        }

        private string bet;

        public string Bet
        {
            get { return bet; }
            set
            {
                bet = value;
                RaisePropertyChanged();
            }
        }

        private List<string> betList;

        public List<string> BetList
        {
            get { return betList; }
            set
            {
                betList = value;
                RaisePropertyChanged();
            }
        }

        public ICommand AddBetCommand { get { return new DelegateCommand(AddBet); } }

        private void AddBet()
        {
            string bet = dbOperations.CreateBet(SelectedMatch.ID, Bet);
            if (bet == "")
            {
                MatchList.Remove(SelectedMatch);
            }
            else
            {
                MessageBox.Show("your bet " + bet);
            }
        }
    }
}
