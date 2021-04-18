using DMess.Supervision.ModelAPI.Converters;
using System.ComponentModel;

namespace DMess.Supervision.CommonModel.Enums
{
    /// <summary>
    /// Тип присоединения
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ConnectionTypes : byte
    {
        /// <summary>
        /// Сварное присоединение
        /// </summary>
        [Description("Св")]
        Weld = 1,

        /// <summary>
        /// Фланцевое присоединение
        /// </summary>
        [Description("Ф")]
        Flange = 2
    }
}
