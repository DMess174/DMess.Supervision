using System.Collections.Generic;
using System.Threading.Tasks;

namespace DMess.Supervision.Shared.Services.Base
{
    public interface ILoadCollectionService<T>
    {
        Task<IEnumerable<T>> LoadDataAsync();
    }
}
