using DMess.Supervision.ModelAPI.Converters;
using System.ComponentModel;

namespace DMess.Supervision.ModelAPI
{
    /// <summary>
    /// Сортамент материала (металл)
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum MetalMaterialAssortment : byte
    {
        /// <summary>
        /// Листовой материал
        /// </summary>
        [Description("Лист")]
        Sheet,

        /// <summary>
        /// Круглый прокат
        /// </summary>
        [Description("Круг")]
        Round,

        /// <summary>
        /// Труба
        /// </summary>
        [Description("Труба")]
        Pipe,

        /// <summary>
        /// Поковка
        /// </summary>
        [Description("Поковка")]
        Forging
    }
}
