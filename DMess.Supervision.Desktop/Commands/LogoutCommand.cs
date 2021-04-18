using DMess.Supervision.Desktop.Commands.Base;
using DMess.Supervision.Desktop.Navigation;
using DMess.Supervision.Desktop.State.Authenticators;

namespace DMess.Supervision.Desktop.Commands
{
    public class LogoutCommand : CommandBase
    {
        private readonly IViewModelRenavigator _renavigator;
        private readonly IAuthenticator _authenticator;

        public LogoutCommand(IAuthenticator authenticator, IViewModelRenavigator renavigator)
        {
            _authenticator = authenticator;
            _renavigator = renavigator;
        }

        public override bool CanExecute(object parameter) => _authenticator.CurrentAccount != null;

        public override void Execute(object parameter)
        {
            _authenticator.Logout();
            _renavigator.Renavigate();
        }
    }
}
