using DMess.Supervision.ModelAPI.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMess.Supervision.CommonModel.Enums
{
    /// <summary>
    /// Тип привода
    /// </summary>
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum DriveTypes : byte
    {
        /// <summary>
        /// Электропривод
        /// </summary>
        [Description("ЭП")]
        Electric = 1,

        /// <summary>
        /// Ручной привод
        /// </summary>
        [Description("РУ")]
        Manual = 2
    }
}
