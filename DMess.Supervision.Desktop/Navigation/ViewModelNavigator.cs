using DMess.Supervision.Desktop.ViewModels;
using System;

namespace DMess.Supervision.Desktop.Navigation
{
    public class ViewModelNavigator : IViewModelNavigator
    {
        private ViewModelBase currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => currentViewModel;
            set
            {
                currentViewModel = value;
                StateChanged?.Invoke();
            }
        }

        public event Action StateChanged;
    }
}
