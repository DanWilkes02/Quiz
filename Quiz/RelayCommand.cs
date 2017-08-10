using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Quiz
{
    public class RelayCommand : ICommand
    {

        private Action<object> _execute;
        private Func<bool> _canExecute;

        public RelayCommand(Action<object> execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public RelayCommand(Action<object> execute) : this(execute, null)
        {

        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            //Always return true if null, otherwise return result of _canExecute
            return _canExecute == null ? true : _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
