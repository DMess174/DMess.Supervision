using DMess.Supervision.Desktop.Commands.Base;
using DMess.Supervision.Desktop.Navigation;
using DMess.Supervision.Desktop.ViewModels;
using System.Threading.Tasks;
using DMess.Supervision.Desktop.State.Authenticators;
using DMess.Supervision.Shared.Exceptions;
using System;

namespace DMess.Supervision.Desktop.Commands
{
    public class LoginCommand : AsyncCommand
    {
        private readonly LoginViewModel _loginViewModel;
        private readonly IViewModelRenavigator _renavigator;
        private readonly IAuthenticator _authenticator;

        public LoginCommand(LoginViewModel loginViewModel, IAuthenticator authenticator, IViewModelRenavigator renavigator)
        {
            _loginViewModel = loginViewModel;
            _authenticator = authenticator;
            _renavigator = renavigator;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _loginViewModel.ErrorMessage = string.Empty;

            try
            {
                await _authenticator.Login(_loginViewModel.Username, _loginViewModel.Password);

                _renavigator.Renavigate();
            }
            catch (UserNotFoundException)
            {
                _loginViewModel.ErrorMessage = "Пользователь не найден";
            }
            catch (InvalidPasswordException)
            {
                _loginViewModel.ErrorMessage = "Неверный пароль.";
            }
            catch (Exception ex)
            {
                _loginViewModel.ErrorMessage = $"Ошибка входа.\n{ex.Message}";
                
            }
        }
    }
}
