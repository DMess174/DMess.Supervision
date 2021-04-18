using DMess.Supervision.CommonModel.Models.Factories;
using DMess.Supervision.ModelAPI;
using System.Collections.Generic;

namespace DMess.Supervision.CommonModel.Models
{
    public class SubdivisionDepartment : AuditableEntity
    {
        public Department Department { get; set; }
        public Subdivision Subdivision { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Factory> Factories { get; set; }
    }
}
