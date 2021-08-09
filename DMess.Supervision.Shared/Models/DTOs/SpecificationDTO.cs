using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMess.Supervision.Shared.Models.DTOs
{

    public class SpecificationDTO : EntityDTO
    {
        private string _number;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(128)]
        public string Number { get => _number; set => Set(ref _number, value); }

        private string _facility;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(2048)]
        public string Facility { get => _facility; set => Set(ref _facility, value); }

        private CustomerDTO _customer;
        public CustomerDTO Customer { get => _customer; set => Set(ref _customer, value); }

        private string _specificationProgramme;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(64)]
        public string SpecificationProgramme { get => _specificationProgramme; set => Set(ref _specificationProgramme, value); }

        private string _specificationStatus;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(128)]
        public string SpecificationStatus { get => _specificationStatus; set => Set(ref _specificationStatus, value); }

        private ICollection<PIDDTO> _pIDs;
        public ICollection<PIDDTO> PIDs { get => _pIDs; set => Set(ref _pIDs, value); }
    }
}