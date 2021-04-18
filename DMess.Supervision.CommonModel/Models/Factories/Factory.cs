using DMess.Supervision.CommonModel.Models.Orders;
using DMess.Supervision.CommonModel.Models.Products;
using DMess.Supervision.ModelAPI;
using System.Collections.Generic;

namespace DMess.Supervision.CommonModel.Models.Factories
{
    public class Factory : AuditableEntity
    {
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string City { get; set; }
        public SubdivisionDepartment SubdivisionDepartment { get; set; }
        public ICollection<ProductType> ProductTypes { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<PID> PIDs { get; set; }
    }
}
