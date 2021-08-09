using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMess.Supervision.Shared.Models.DTOs
{

    public class SubdivisionDepartmentDTO : EntityDTO
    {
        private SubdivisionDTO _subdivision;
        public SubdivisionDTO Subdivision { get => _subdivision; set => Set(ref _subdivision, value); }

        private DepartmentDTO _department;
        public DepartmentDTO Department { get => _department; set => Set(ref _department, value); }

        private ICollection<EmployeeDTO> _employees;
        public ICollection<EmployeeDTO> Employees { get => _employees; set => Set(ref _employees, value); }

        private ICollection<FactoryDTO> _factories;
        public ICollection<FactoryDTO> Factories { get => _factories; set => Set(ref _factories, value); }
    }
}
