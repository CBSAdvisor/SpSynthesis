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

                if (!_dbContext.Database.Exists())
                {
                    Database.SetInitializer(new SpSynthDbInitializer());
                    //Database.DefaultConnectionFactory = new SqlCeConnectionFactory(
                    //    "System.Data.SqlServerCe.4.0",
                    //    @"D:\Projects\github-repo\SpSynthesis\SpSynthesis\SpSynthesis.UI\bin\Debug\Data\",
                    //    @"Data Source=D:\Projects\github-repo\SpSynthesis\SpSynthesis\SpSynthesis.UI\bin\Debug\Data\SpSynth.sdf");
                }
                else
                {
                    Database.SetInitializer(new MigrateDatabaseToLatestVersion<SpSynthDbContext, SpSynthMigrationConfig>());
                }
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
