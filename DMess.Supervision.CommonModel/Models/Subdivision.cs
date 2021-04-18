using DMess.Supervision.ModelAPI;
using System.Collections.Generic;

namespace DMess.Supervision.CommonModel.Models
{
    public class Subdivision : AuditableEntity
    {
        public string Name { get; set; }
        public string City { get; set; }
        public ICollection<SubdivisionDepartment> Departments { get; set; }
    }
}
