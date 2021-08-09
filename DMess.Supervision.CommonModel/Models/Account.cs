using DMess.Supervision.ModelAPI;

namespace DMess.Supervision.CommonModel.Models
{
    public class Account : AuditableEntity
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public bool IsLoggedIn { get; set; }
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
