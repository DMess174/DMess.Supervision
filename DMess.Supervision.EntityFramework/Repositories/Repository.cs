using DMess.Supervision.EntityFramework.Contexts;
using DMess.Supervision.ModelAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DMess.Supervision.EntityFramework.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly CommonDataContextFactory _contextFactory;

        public Repository(CommonDataContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public T Create(T item)
        {
            using var context = _contextFactory.CreateDbContext();
            EntityEntry<T> createdResult = context.Set<T>().Add(item);
            context.SaveChanges();

            return createdResult.Entity;
        }

        public async Task<T> CreateAsync(T item, CancellationToken cancel = default)
        {
            if (!(item is null)) throw new ArgumentNullException(nameof(item));

            await using var context = _contextFactory.CreateDbContext();
            EntityEntry<T> createdResult = await context.Set<T>().AddAsync(item);
            await context.SaveChangesAsync();

            return createdResult.Entity;
        }

        public virtual IEnumerable<T> GetAll()
        {
            using var context = _contextFactory.CreateDbContext();

            return context.Set<T>().AsNoTracking().ToList();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancel = default)
        {
            await using var context = _contextFactory.CreateDbContext();

            return await context.Set<T>().AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        public virtual T GetById(string id)
        {
            using var context = _contextFactory.CreateDbContext();

            return context.Set<T>().SingleOrDefault(i => i.Id == id);
        }

        public virtual async Task<T> GetByIdAsync(string id, CancellationToken cancel = default)
        {
            await using var context = _contextFactory.CreateDbContext();

            return await context.Set<T>().SingleOrDefaultAsync(i => i.Id == id).ConfigureAwait(false);
        }

        public void Remove(string id)
        {
            using var context = _contextFactory.CreateDbContext();

            var entityToDelete = context.Set<T>().SingleOrDefault(i => i.Id == id);
            if (entityToDelete is null) return;

            context.Remove(entityToDelete);
        }

        public async Task RemoveAsync(string id, CancellationToken cancel = default)
        {
            await using var context = _contextFactory.CreateDbContext();
            var entityToDelete = await context.Set<T>().SingleOrDefaultAsync(i => i.Id == id).ConfigureAwait(false);
            
            if (entityToDelete is null) return;

            context.Remove(entityToDelete);
            await context.SaveChangesAsync();
        }

        public void Update(T item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));

            var context = _contextFactory.CreateDbContext();
            context.Set<T>().Update(item);
            context.SaveChanges();
        }

        public async Task UpdateAsync(T item, CancellationToken cancel = default)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));

            await using var context = _contextFactory.CreateDbContext();
            context.Set<T>().Update(item);
            await context.SaveChangesAsync();
        }
    }
}
