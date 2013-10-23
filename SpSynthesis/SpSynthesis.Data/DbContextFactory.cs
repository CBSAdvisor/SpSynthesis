using SpSynthesis.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpSynthesis.Data
{
    public class DbContextFactory : IDbContextFactory
    {
        private SpSynthDbContext _dbContext = null;

        public DbContextFactory(ILogger logger)
        {
            Logger = logger;
        }

        public IDbContext GetDbContext()
        {
            //if (_dbContext != null)
            //{
            //    return _dbContext;
            //}

            try
            {
                _dbContext = new SpSynthDbContext(); 

                //if (!_dbContext.Database.Exists())
                //{
                //    Database.SetInitializer(new SpSynthDbInitializer());
                //}
                //else
                //{
                //    Database.SetInitializer(new MigrateDatabaseToLatestVersion<SpSynthDbContext, SpSynthMigrationConfig>());
                //}

                Database.SetInitializer(new SpSynthDbInitializer());
                _dbContext.Database.Initialize(true);
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }

            return _dbContext;
        }

        public ILogger Logger { get; set; }
    }
}
