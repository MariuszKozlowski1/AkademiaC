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
    class ResultsViewModel : BaseViewModel
    {
        public ResultsViewModel()
        {
            ResultsList = dbOperations.ReadResults();
        }

        private ObservableCollection<UserWithPoints> resultsList;

        public ObservableCollection<UserWithPoints> ResultsList
        {
            get { return resultsList; }
            set
            {
                resultsList = value;
                RaisePropertyChanged();
            }
        }

    }
}
