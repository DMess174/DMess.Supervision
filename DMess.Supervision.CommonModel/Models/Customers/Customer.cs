using DMess.Supervision.CommonModel.Models.Contracts;
using DMess.Supervision.CommonModel.Models.Orders;
using DMess.Supervision.ModelAPI;
using System.Collections.Generic;

namespace DMess.Supervision.CommonModel.Models.Customers
{
    public class Customer : AuditableEntity
    {
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Specification> Specifications { get; set; }
    }
}
