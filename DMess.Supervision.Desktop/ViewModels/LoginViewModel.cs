using DMess.Supervision.Desktop.Commands;
using DMess.Supervision.Desktop.Navigation;
using DMess.Supervision.Desktop.ViewModels.Base;
using DMess.Supervision.Desktop.ViewModels.Messages;
using DMess.Supervision.Desktop.State.Authenticators;
using System.Windows.Input;

namespace DMess.Supervision.Desktop.ViewModels
{
	public class LoginViewModel : ViewModelBase
	{
		public bool IsBusy { get; set; }

		public string Username { get; set; } = "amburtsevda";

		public string Password { get; set; } = "1234567";

		public MessageViewModel ErrorMessageViewModel { get; }

		public string ErrorMessage
		{
			set => ErrorMessageViewModel.Message = value;
		}

		public ICommand LoginCommand { get; }

		public LoginViewModel(IAuthenticator authenticator, IViewModelRenavigator renavigator)
		{
			ErrorMessageViewModel = new MessageViewModel();
			LoginCommand = new LoginCommand(this, authenticator, renavigator);
		}

		public static LoginViewModel LoadViewModel(IAuthenticator authenticator, IViewModelRenavigator renavigator)
		{
			var vm = new LoginViewModel(authenticator, renavigator);
			return vm;
		}
	}
}
