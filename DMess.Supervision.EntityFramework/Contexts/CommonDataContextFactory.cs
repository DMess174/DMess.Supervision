using Microsoft.EntityFrameworkCore;
using System;

namespace DMess.Supervision.EntityFramework.Contexts
{
    public class CommonDataContextFactory 
    {
        private readonly Action<DbContextOptionsBuilder> _configureDbContext;

        public CommonDataContextFactory(Action<DbContextOptionsBuilder> configureDbContext)
        {
            _configureDbContext = configureDbContext;
        }

        public CommonDataContext CreateDbContext()
        {
            DbContextOptionsBuilder<CommonDataContext> options = new DbContextOptionsBuilder<CommonDataContext>();

            _configureDbContext(options);

            return new CommonDataContext(options.Options);
        }
    }
}
