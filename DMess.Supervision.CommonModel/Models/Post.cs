using DMess.Supervision.ModelAPI;
using System.Collections.Generic;

namespace DMess.Supervision.CommonModel.Models
{
    public class Post : AuditableEntity
    {
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}