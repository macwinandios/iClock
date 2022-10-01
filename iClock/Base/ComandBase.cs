using System;
using System.Windows.Input;

namespace iClock.Base
{
    public class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;
        
        public CommandBase()
        {

        }
        public CommandBase(Action<object> execute) : this(execute, null) 
        { 
        
        }
        public CommandBase(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
            if (execute == null) throw new ArgumentNullException("execute");
            
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }
        
        public void Execute(object parameter) 
        { 
            _execute(parameter); 
        }

    }
}
