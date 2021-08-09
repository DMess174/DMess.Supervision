using System;
using System.Threading.Tasks;

namespace DMess.Supervision.Desktop.Commands.Base
{
    public abstract class AsyncCommand : CommandBase
    {
        private bool _isExecuting;
        public bool IsExecuting
        {
            get => _isExecuting;
            set
            {
                _isExecuting = value;
                CanExecuteChanged?.Invoke(this, new EventArgs());
            }
        }

        public new event EventHandler CanExecuteChanged;

        public override bool CanExecute(object parameter) => !IsExecuting;

        public override async void Execute(object parameter)
        {
            IsExecuting = true;

            await ExecuteAsync(parameter);

            IsExecuting = false;
        }

        public abstract Task ExecuteAsync(object parameter);
    }
}
