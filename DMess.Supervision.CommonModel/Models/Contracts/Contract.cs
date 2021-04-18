using DMess.Supervision.CommonModel.Models.Customers;
using DMess.Supervision.ModelAPI;
using System;

namespace DMess.Supervision.CommonModel.Models.Contracts
{
    public class Contract : AuditableEntity
    {
        public string Number { get; set; }
        public DateTime SignDate { get; set; }
        public bool IsInForce { get; set; }
        public Customer Customer { get; set; }
    }
}
