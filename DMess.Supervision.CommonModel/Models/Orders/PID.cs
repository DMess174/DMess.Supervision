using DMess.Supervision.CommonModel.Enums;
using DMess.Supervision.CommonModel.Models.Factories;
using DMess.Supervision.CommonModel.Models.Products;
using DMess.Supervision.ModelAPI;
using System;

namespace DMess.Supervision.CommonModel.Models.Orders
{
    public class PID : AuditableEntity, IOrderEntity
    {
        public string Number { get; set; }
        public int ProductQuantity { get; set; }
        public string Consignee { get; set; }
        public DateTime ShipmentDate { get; set; }
        public Specification Specification { get; set; }
        public Factory Factory { get; set; }
        public ProductType ProductType { get; set; }
        public PIDStatus Status { get; set; } = PIDStatus.Work;
        
        //public ICollection<PIDCoatingDocument> CoatingDocuments { get; set; }
    }
}
