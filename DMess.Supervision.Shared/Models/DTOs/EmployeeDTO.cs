using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMess.Supervision.Shared.Models.DTOs
{
    public class EmployeeDTO : EntityDTO
    {
        private string _firstName;
        [Required(ErrorMessage = "Поле \"Имя\" не может быть пустым")]
        [StringLength(128)]
        public string FirstName
        {
            get => _firstName;
            set
            {
                Set(ref _firstName, value);
                OnPropertyChanged(nameof(FullName));
            }
        }

        private string _lastName;
        [Required(ErrorMessage = "Поле \"Фамилия\" не может быть пустым")]
        [StringLength(128)]
        public string LastName
        {
            get => _lastName;
            set
            {
                Set(ref _lastName, value);
                OnPropertyChanged(nameof(FullName));
            }
        }

        private string _patronymic;
        public string Patronymic
        {
            get => _patronymic;
            set
            {
                Set(ref _patronymic, value);
                OnPropertyChanged(nameof(FullName));
            }
        }

        public string FullName
        {
            get => _firstName[0] + "." + (string.IsNullOrEmpty(_patronymic)? "" : _patronymic[0]) + ". " + _lastName;
        }

        private string _email;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [EmailAddress(ErrorMessage = "Некооректный формат адреса")]
        public string Email { get => _email; set => Set(ref _email, value); }

        private string _phoneNumber;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        //TODO: Uncomment
        [Phone(ErrorMessage = "Некооректный формат номера")]
        public string PhoneNumber { get => _phoneNumber; set => Set(ref _phoneNumber, value); }

        private string _photoPath;
        public string PhotoPath { get => _photoPath; set => Set(ref _photoPath, value); }

        private DateTime _birthDate;
        public DateTime BirthDate { get => _birthDate; set => Set(ref _birthDate, value); }

        private PostDTO _post;
        public PostDTO Post { get => _post; set => Set(ref _post, value); }

        private AccountDTO _account;
        public AccountDTO Account { get => _account; set => Set(ref _account, value); }

        private SubdivisionDepartmentDTO _department;
        public SubdivisionDepartmentDTO Department { get => _department; set => Set(ref _department, value); }

        private ICollection<FactoryDTO> _factories;
        public ICollection<FactoryDTO> Factories { get => _factories; set => Set(ref _factories, value); }
    }
}
