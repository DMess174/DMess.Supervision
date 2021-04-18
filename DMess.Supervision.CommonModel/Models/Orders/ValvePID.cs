using DMess.Supervision.CommonModel.Enums;

namespace DMess.Supervision.CommonModel.Models.Orders
{
    public class ValvePID : PID
    {
        public Diameters Diameter { get; set; }
        public Pressures PressureLimit { get; set; }
        public Pressures PressureDifference { get; set; }
        public ConnectionTypes ConnectionType { get; set; }
        public DriveTypes DriveType { get; set; }
        public SeismicStabilityCategories SeismicStability { get; set; }
        public ClimaticModifications ClimaticModification { get; set; }
    }
}
