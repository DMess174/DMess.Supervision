using DMess.Supervision.CommonModel.Enums;
using DMess.Supervision.CommonModel.Models.Customers;
using DMess.Supervision.ModelAPI;
using System.Collections.Generic;

namespace DMess.Supervision.CommonModel.Models.Orders
{
    public class Specification : AuditableEntity
    {
        public string Number { get; set; }
        public string Facility { get; set; }
        public Customer Customer { get; set; }
        public SpecificationProgrammes Programme { get; set; }
        public SpecificationStatus Status { get; set; } = SpecificationStatus.Signed;
        public ICollection<PID> PIDs { get; set; }
    }
}
