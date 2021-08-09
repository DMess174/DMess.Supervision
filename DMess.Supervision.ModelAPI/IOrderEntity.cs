using System;

namespace DMess.Supervision.ModelAPI
{
    /// <summary>
    /// Заказ контрагента
    /// </summary>
    public interface IOrderEntity : IAuditableEntity
    {
        string Number { get; set; }
        int ProductQuantity { get; set; }
        string Consignee { get; set; }
        public DateTime ShipmentDate { get; set; }
    }
}
