using DMess.Supervision.ModelAPI.Converters;
using System.ComponentModel;

namespace DMess.Supervision.CommonModel.Enums
{
    /// <summary>
    /// Климатическое исполнение
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ClimaticModifications : byte
    {
        /// <summary>
        /// У1
        /// </summary>
        [Description("У1")]
        Temperate = 1,

        /// <summary>
        /// ХЛ1
        /// </summary>
        [Description("ХЛ1")]
        Cold = 2,

        /// <summary>
        /// УХЛ4
        /// </summary>
        [Description("УХЛ4")]
        TemperateCold = 3
    }
}
