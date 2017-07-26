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
    class AddResultViewModel : BaseViewModel
    {
        public AddResultViewModel()
        {
            ResultsList = new List<string>();
            for (int i = 15; i < 76; i++)
            {
                ResultsList.Add((90 - i).ToString() + ":" + i);
            }
            MatchList = new ObservableCollection<tblMatches>();
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

        private string resultToAdd;

        public string ResultToAdd
        {
            get { return resultToAdd; }
            set
            {
                resultToAdd = value;
                RaisePropertyChanged();
            }
        }

        private List<string> resultsList;

        public List<string> ResultsList
        {
            get { return resultsList; }
            set
            {
                resultsList = value;
                RaisePropertyChanged();
            }
        }

        public ICommand AddResultCommand { get { return new DelegateCommand(AddResult); } }

        private void AddResult()
        {
            int matchId = SelectedMatch.ID;

            selectedMatch.Result = resultToAdd;
            matchList.Add(selectedMatch);
            dbOperations.UpdateMatchesWithResult(SelectedMatch.ID, ResultToAdd);
            for (int i = 0; i < matchList.Count; i++)
            {
                if (matchList[i].ID == matchId)
                {
                    matchList.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
