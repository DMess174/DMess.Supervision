using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DMess.Supervision.ModelAPI
{
    /// <summary>
    /// Base data access interface
    /// </summary>
    /// <typeparam name="T">Entity class</typeparam>
    public interface IRepository<T> where T : class, IEntity
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancel = default);

        T GetById(string id);
        Task<T> GetByIdAsync(string id, CancellationToken cancel = default);

        T Create(T item);
        Task<T> CreateAsync(T item, CancellationToken cancel = default);

        void Update(T item);
        Task UpdateAsync(T item, CancellationToken cancel = default);

        void Remove(string id);
        Task RemoveAsync(string id, CancellationToken cancel = default);
    }
}
