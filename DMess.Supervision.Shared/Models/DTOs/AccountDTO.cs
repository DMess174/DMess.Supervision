using System.ComponentModel.DataAnnotations;

namespace DMess.Supervision.Shared.Models.DTOs
{
    public class AccountDTO : EntityDTO
    {
        private string _userName;
        [Required(ErrorMessage = "Имя пользователя не может быть пустым")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Имя пользователя должно быть длиной более 5 символов")]
        public string UserName 
        { 
            get => _userName; 
            set => Set(ref _userName, value); 
        }

        private bool _isLoggedIn;
        public bool IsLoggedIn 
        { 
            get => _isLoggedIn; 
            set => Set(ref _isLoggedIn, value); 
        }

        private EmployeeDTO _employee;
        public EmployeeDTO Employee 
        { 
            get => _employee; 
            set => Set(ref _employee, value);
        }
    }
}
