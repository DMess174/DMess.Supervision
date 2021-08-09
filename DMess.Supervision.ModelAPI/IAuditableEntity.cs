using System;

namespace DMess.Supervision.ModelAPI
{
    /// <summary>
    /// Аудируемая сущность
    /// </summary>
    public interface IAuditableEntity
    {
        DateTime CreatedAt { get; }
        string CreatedBy { get; }
        DateTime UpdatedAt { get; set; }
        string UpdatedBy { get; set; }
    }
}
