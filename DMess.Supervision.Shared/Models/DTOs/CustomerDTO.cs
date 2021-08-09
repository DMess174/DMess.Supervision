using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMess.Supervision.Shared.Models.DTOs
{
    public class CustomerDTO : EntityDTO
    {
        private string _fullName;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(128)]
        public string FullName { get => _fullName; set => Set(ref _fullName, value); }

        private string _shortName;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(64)]
        public string ShortName { get => _shortName; set => Set(ref _shortName, value); }

        private ICollection<ContractDTO> _contracts;
        public ICollection<ContractDTO> Contracts { get => _contracts; set => Set(ref _contracts, value); }

        private ICollection<SpecificationDTO> _specifications;
        public ICollection<SpecificationDTO> Specifications { get => _specifications; set => Set(ref _specifications, value); }
    }
}