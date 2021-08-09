using DMess.Supervision.CommonModel.Models.Factories;
using DMess.Supervision.CommonModel.Models.Orders;
using DMess.Supervision.ModelAPI;
using System.Collections.Generic;

namespace DMess.Supervision.CommonModel.Models.Products
{
    public class ProductType : AuditableEntity
    {
        public string FullName { get; set; }
        public string ShortName { get; set; }
        //public ProductDocument Document { get; set; }
        public ICollection<Factory> Factories { get; set; }
        public ICollection<PID> PIDs { get; set; }
    }
}
