using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMess.Supervision.Shared.Models.DTOs
{

    public class PostDTO : EntityDTO
    {
        private string _name;
        public string Name { get => _name; set => Set(ref _name, value); }

        private ICollection<EmployeeDTO> _employees;
        public ICollection<EmployeeDTO> Employees { get => _employees; set => Set(ref _employees, value); }
    }
}
