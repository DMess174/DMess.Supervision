using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMess.Supervision.Shared.Models.DTOs
{
    public class FactoryDTO : EntityDTO
    {
        private string _fullName;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(128)]
        public string FullName { get => _fullName; set => Set(ref _fullName, value); }

        private string _shortName;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(128)]
        public string ShortName { get => _shortName; set => Set(ref _shortName, value); }

        private string _city;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(128)]
        public string City { get => _city; set => Set(ref _city, value); }

        private SubdivisionDepartmentDTO _department;
        public SubdivisionDepartmentDTO Department { get => _department; set => Set(ref _department, value); }

        private ICollection<ProductTypeDTO> _productTypes;
        public ICollection<ProductTypeDTO> ProductTypes { get => _productTypes; set => Set(ref _productTypes, value); }

        private ICollection<EmployeeDTO> _employees;
        public ICollection<EmployeeDTO> Employees { get => _employees; set => Set(ref _employees, value); }

        private ICollection<PIDDTO> _pIDs;
        public ICollection<PIDDTO> PIDs { get => _pIDs; set => Set(ref _pIDs, value); }
    }
}
