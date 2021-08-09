using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMess.Supervision.Shared.Models.DTOs
{

    public class SubdivisionDTO : EntityDTO
    {
        private string _name;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(256)]
        public string Name { get => _name; set => Set(ref _name, value); }

        private string _city;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(128)]
        public string City { get => _city; set => Set(ref _city, value); }

        private ICollection<SubdivisionDepartmentDTO> _departments;
        public ICollection<SubdivisionDepartmentDTO> Departments { get => _departments; set => Set(ref _departments, value); }
    }
}
