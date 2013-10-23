using SpSynthesis.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
//using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpSynthesis.Data
{
    public class UnitOfWork : IEFUnitOfWork
    {
        private readonly SpSynthDbContext _dbContext;

        public UnitOfWork(ILogger logger, IDbContext dbContext)
        {
            Logger = logger;
            _dbContext = dbContext as SpSynthDbContext;
        }

        public ILogger Logger { get; set; }

        /// <summary>
        /// Commits this instance.
        /// </summary>
        public void Commit()
        {
            _dbContext.SaveChanges();
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
