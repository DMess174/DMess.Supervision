using DMess.Supervision.ModelAPI.Converters;
using System.ComponentModel;

namespace DMess.Supervision.ModelAPI
{
    /// <summary>
    /// Тип производства деталей, комплектующих
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum PartProductionType : byte
    {
        /// <summary>
        /// Произведен собственными силами либо на стороне из собственного материала
        /// </summary>
        [Description("Собственное производство")]
        Self,

        /// <summary>
        /// Произведен на стороне
        /// </summary>
        [Description("Покупной")]
        Purchase
    }
}
