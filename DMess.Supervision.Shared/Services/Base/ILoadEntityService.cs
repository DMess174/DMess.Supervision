using System.Threading.Tasks;

namespace DMess.Supervision.Shared.Services.Base
{
    public interface ILoadEntityService<T>
    {
        Task<T> LoadDataAsync(string id);
    }
}
