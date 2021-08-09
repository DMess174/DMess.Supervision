using DMess.Supervision.ModelAPI.Converters;
using System.ComponentModel;

namespace DMess.Supervision.CommonModel.Enums
{
    /// <summary>
    /// PID status
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum PIDStatus : byte
    {
        /// <summary>
        /// В работе
        /// </summary>
        [Description("В работе")]
        Work = 1,

        /// <summary>
        /// Закрыт
        /// </summary>
        [Description("Закрыт")]
        Done = 2,

        /// <summary>
        /// Отменен
        /// </summary>
        [Description("Отменен")]
        Cancel = 3
    }
}
