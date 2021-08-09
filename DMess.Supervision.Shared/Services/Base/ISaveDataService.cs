using System.Threading.Tasks;

namespace DMess.Supervision.Shared.Services.Base
{
    public interface ISaveDataService<T>
    {
        Task<T> SaveDataAsync(T entity);
    }
}
