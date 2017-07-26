using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using SpeedwayBetting.Helpers;
using SpeedwayBetting.Models;
using SpeedwayBetting.Views;

namespace SpeedwayBetting.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        #region Pola
        private UserLoginControl userLoginControl = new UserLoginControl();
        private UserRegistrationControl userRegistrationControl;
        private AddMatchControl addMatchControl;
        private AddResultControl addResultControl;
        private BetControl betControl;
        private ResultsControl resultsControl;

        #endregion

        #region Konstruktor
        public MainWindowViewModel()
        {
            User = new tblUsers();
            MenuCommonVisibility = Visibility.Hidden.ToString();
            MenuAdminVisibility = Visibility.Hidden.ToString();
            CenterView = userLoginControl;
        }

        #endregion

        private UserControl centerView;

        public UserControl CenterView
        {
            get { return centerView; }
            set
            {
                centerView = value;
                RaisePropertyChanged();
            }
        }

        private string menuCommonVisibility;

        public string MenuCommonVisibility
        {
            get { return menuCommonVisibility; }
            set
            {
                menuCommonVisibility = value;
                RaisePropertyChanged();
            }
        }

        private string menuAdminVisibility;

        public string MenuAdminVisibility
        {
            get { return menuAdminVisibility; }
            set
            {
                menuAdminVisibility = value;
                RaisePropertyChanged();
            }
        }

        private tblUsers user;

        public tblUsers User
        {
            get { return user; }
            set
            {
                user = value;
                RaisePropertyChanged();
            }
        }

        public ICommand ShowLoginCommand { get { return new DelegateCommand(ShowLogin); } }
        public ICommand ShowRegistrationCommand { get { return new DelegateCommand(ShowRegistration); } }
        public ICommand ShowAddMatchCommand { get { return new DelegateCommand(ShowAddMatch); } }
        public ICommand ShowAddResultCommand { get { return new DelegateCommand(ShowAddResult); } }
        public ICommand ShowBetCommand { get { return new DelegateCommand(ShowBet); } }
        public ICommand ShowResultsCommand { get { return new DelegateCommand(ShowResults); } }
        public ICommand LogoutCommand { get { return new DelegateCommand(Logout); } }
        public ICommand ExitCommand { get { return new DelegateCommand(Exit); } }

        public ICommand LoginCommand { get { return new DelegateCommand(Login); } }
        public ICommand RegistrationCommand { get { return new DelegateCommand(Registration); } }

        private void ShowLogin()
        {
            if (userLoginControl == null) userLoginControl = new UserLoginControl();
            CenterView = userLoginControl;
            userLoginControl = null;
        }
        
        private void ShowRegistration()
        {
            if (userRegistrationControl == null) userRegistrationControl = new UserRegistrationControl();
            CenterView = userRegistrationControl;
            userRegistrationControl = null;
        }

        private void ShowAddMatch()
        {
            if (addMatchControl == null) addMatchControl = new AddMatchControl();
            CenterView = addMatchControl;
            addMatchControl = null;
        }

        private void ShowAddResult()
        {
            if (addResultControl == null) addResultControl = new AddResultControl();
            CenterView = addResultControl;
            addResultControl = null;
        }

        private void ShowBet()
        {
            if (betControl == null) betControl = new BetControl();
            CenterView = betControl;
            betControl = null;
        }


        private void ShowResults()
        {
            if (resultsControl == null) resultsControl = new ResultsControl();
            CenterView = resultsControl;
            resultsControl = null;
        }

        private void Login()
        {
            if (dbOperations.UserLogin(User))
            {
                User.Login = "";
                User.Password = "";
                MenuCommonVisibility = Visibility.Visible.ToString();
                if (Properties.Settings.Default.UserLogin == "Admin")
                {
                    MenuAdminVisibility = Visibility.Visible.ToString();
                }
                else
                {
                    MenuAdminVisibility = Visibility.Hidden.ToString();
                }
                ShowBet();
            }
            else
            {
                MenuCommonVisibility = Visibility.Hidden.ToString();
                MessageBox.Show("Wrong user or password");
            }
        }

        private void Registration()
        {
            dbOperations.CreateUser(User);
            MessageBox.Show("ok");
        }
        private void Logout()
        {
            MenuAdminVisibility = Visibility.Hidden.ToString();
            MenuCommonVisibility = Visibility.Hidden.ToString();
            Properties.Settings.Default.UserLogin = "";
            Properties.Settings.Default.UserID = 0;
            ShowLogin();
        }
        private void Exit()
        {
            Application.Current.Shutdown();
        }

    }
}
