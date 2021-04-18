using DMess.Supervision.ModelAPI;
using System.Collections.Generic;

namespace DMess.Supervision.CommonModel.Models
{
    public class Department : AuditableEntity
    {
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public ICollection<SubdivisionDepartment> Subdivisions { get; set; }
    }
}
