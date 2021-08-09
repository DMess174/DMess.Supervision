using DMess.Supervision.Desktop.Commands;
using DMess.Supervision.Desktop.Navigation;
using DMess.Supervision.Desktop.State.Authenticators;
using DMess.Supervision.Desktop.ViewModels.Base;
using System.Windows.Input;

namespace DMess.Supervision.Desktop.ViewModels
{
    public class HeadViewModel : ViewModelBase
    {
        #region Private

        /// <summary>
        /// Account status property
        /// </summary>
        private readonly IAuthenticator _authenticator;

        /// <summary>
        /// Switch view-models navigator
        /// </summary>
        private readonly IViewModelNavigator _navigator;

        /// <summary>
        /// ViewModel factory to switch view-models
        /// </summary>
        private readonly IViewModelFactory _viewModelFactory;

        #endregion

        #region Public Properties

        public bool IsLoggedIn => _authenticator.IsLoggedIn;

        public ViewModelBase CurrentViewModel => _navigator.CurrentViewModel;

        #endregion

        #region Commands

        /// <summary>
        /// The command to switch view models
        /// </summary>
        public ICommand UpdateCurrentViewModelCommand { get; }

        #endregion

        #region Constructor

        public HeadViewModel(IAuthenticator authenticator, IViewModelNavigator navigator, IViewModelFactory viewModelFactory)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
            _authenticator = authenticator;

            _navigator.StateChanged += Navigator_StateChanged;
            _authenticator.StateChanged += Authenticator_StateChanged;

            UpdateCurrentViewModelCommand = new UpdateCurrentViewModelCommand(navigator, _viewModelFactory);
            UpdateCurrentViewModelCommand.Execute(ViewType.Login);
        }

        #endregion

        #region Private Methods
        private void Authenticator_StateChanged()
        {
            OnPropertyChanged(nameof(IsLoggedIn));
        }

        private void Navigator_StateChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
        #endregion
    }
}