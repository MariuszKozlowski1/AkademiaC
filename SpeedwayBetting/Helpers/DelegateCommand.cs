using System;
using System.Windows.Input;

namespace SpeedwayBetting.Helpers
{
    public class DelegateCommand : ICommand
    {
        private Action command;
        private Func<bool> canExecute;

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute();
        }

        public void Execute(object parameter)
        {
            command();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public DelegateCommand(Action command, Func<bool> canExecute = null)
        {
            this.canExecute = canExecute;
            if (command != null)
                this.command = command;
        }
    }
}
