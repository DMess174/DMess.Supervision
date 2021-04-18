using System;
using System.ComponentModel.DataAnnotations;

namespace DMess.Supervision.Shared.Models.DTOs
{
    public class ContractDTO : EntityDTO
    {
        private string _number;
        [Required(ErrorMessage = "Поле \"Номер\" не может быть пустым")]
        [StringLength(128)]
        public string Number { get => _number; set => Set(ref _number, value); }

        private DateTime _signDate;
        [Required(ErrorMessage = "Заполните дату")]
        public DateTime SignDate { get => _signDate; set => Set(ref _signDate, value); }

        private bool _isInForce;
        public bool IsInForce { get => _isInForce; set => Set(ref _isInForce, value); }

        private CustomerDTO _customer;
        public CustomerDTO Customer { get => _customer; set => Set(ref _customer, value); }
    }
}
