using System;

namespace DMess.Supervision.ModelAPI
{
    /// <summary>
    /// Материал
    /// </summary>
    public interface IMaterialEntity : IAuditableEntity
    {
        string Number { get; }
        string Batch { get; set; }
        string Certificate { get; set; }
        DateTime CertificateDate { get; set; }
    }
}
