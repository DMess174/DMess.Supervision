using DMess.Supervision.ModelAPI.Converters;
using System.ComponentModel;

namespace DMess.Supervision.CommonModel.Enums
{
    /// <summary>
    /// Программа поставки 
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum SpecificationProgrammes : byte
    {
        /// <summary>
        /// ТПР (Техническое перевооружение)
        /// </summary>
        [Description("ТПР")]
        TechnicalExtensions = 1,

        /// <summary>
        /// РЭН (Ремонтные нужды)
        /// </summary>
        [Description("РЭН")]
        OperationMaintenance = 2,

        /// <summary>
        /// Прочее
        /// </summary>
        [Description("Прочее")]
        Else = 3
    }
}
