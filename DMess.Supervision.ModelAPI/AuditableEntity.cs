using System;

namespace DMess.Supervision.ModelAPI
{
    public abstract class AuditableEntity : Entity, IAuditableEntity
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public AuditableEntity()
        {
            CreatedAt = DateTime.Now;
        }

        public AuditableEntity(string creator) : this()
        {
            CreatedBy = creator;
        }
    }
}
