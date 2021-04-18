using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMess.Supervision.Shared.Models.DTOs
{

    public class DepartmentDTO : EntityDTO
    {
        private string _fullName;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(256)]
        public string FullName { get => _fullName; set => Set(ref _fullName, value); }

        private string _shortName;
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(64)]
        public string ShortName { get => _shortName; set => Set(ref _shortName, value); }

        private ICollection<SubdivisionDepartmentDTO> _subdivisions;
        public ICollection<SubdivisionDepartmentDTO> Subdivisions { get => _subdivisions; set => Set(ref _subdivisions, value); }
    }
}
