using DMess.Supervision.Desktop.ViewModels.Base;
using System;

namespace DMess.Supervision.Desktop.Navigation
{
    public class ViewModelNavigator : IViewModelNavigator
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel?.Dispose();

                _currentViewModel = value;
                StateChanged?.Invoke();
            }
        }

        public event Action StateChanged;
    }
}
