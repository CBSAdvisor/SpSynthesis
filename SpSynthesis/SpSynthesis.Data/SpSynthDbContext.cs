using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using SpSynthesis.Data.Mapping;

namespace SpSynthesis.Data
{
    /// <summary>
    /// Class KbToolsContext
    /// </summary>
    public class SpSynthDbContext : DbContext, IDbContext
    {
        public SpSynthDbContext()
            : base("name=SpSynthDbContext")
        {
            //var directory = Path.GetDirectoryName(Assembly.GetAssembly(typeof(KbToolsContect)).Location);
            //var path = Path.Combine(directory, @"Data\Blogging.sdf");

            //var connectionString = string.Format("Data Source={0}", path);
            //Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0", "", connectionString);
        }

        public SpSynthDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public SpSynthDbContext(string nameOrConnectionString, DbCompiledModel model)
            : base(nameOrConnectionString, model)
        {
        }

        public SpSynthDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public SpSynthDbContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        /// before the model has been locked down and used to initialize the context.  The default
        /// implementation of this method does nothing, but it can be overridden in a derived class
        /// such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        /// <remarks>Typically, this method is called only once when the first instance of a derived context
        /// is created.  The model for that context is then cached and is for all further instances of
        /// the context in the app domain.  This caching can be disabled by setting the ModelCaching
        /// property on the given ModelBuidler, but note that this can seriously degrade performance.
        /// More control over caching is provided through use of the DbModelBuilder and DbContextFactory
        /// classes directly.</remarks>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new RaceMapping());
            modelBuilder.Configurations.Add(new CreatureMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
