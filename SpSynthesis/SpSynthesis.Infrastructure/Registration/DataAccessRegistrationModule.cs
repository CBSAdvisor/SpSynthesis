using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SpSynthesis.Data;

namespace SpSynthesis.Infrastructure.Registration
{
    public class DataAccessRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DbContextFactory>()
                .As<IDbContextFactory>()
                .SingleInstance();

            builder.Register(c => c.Resolve<IDbContextFactory>().GetDbContext())
            .As<IDbContext>()
            .InstancePerLifetimeScope(); 

            builder.RegisterType<UnitOfWork>()
                .As<IEFUnitOfWork>()
                .InstancePerLifetimeScope();
        }
    }
}
