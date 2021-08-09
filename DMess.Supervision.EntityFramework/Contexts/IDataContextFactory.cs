using Microsoft.EntityFrameworkCore;

namespace DMess.Supervision.EntityFramework.Contexts
{
    public interface IDataContextFactory
    {
        DbContext CreateDbContext();
    }
}
