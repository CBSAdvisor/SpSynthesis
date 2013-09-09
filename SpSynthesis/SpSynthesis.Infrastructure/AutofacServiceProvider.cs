using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SpSynthesis.Infrastructure.Extentions;
using IServiceProvider = SpSynthesis.Core.IServiceProvider;

namespace SpSynthesis.Infrastructure
{
    public class AutofacServiceProvider : IServiceProvider
    {
        private ILifetimeScope _container;

        public AutofacServiceProvider(ILifetimeScope container)
        {
            _container = container;
        }
        #region Implementation of IServiceProvider

        public T ResolveInstance<T>()
        {
            return _container
                .Resolve<T>();
        }

        public object ResolveInstance(Type service)
        {
            return _container
              .Resolve(service);
        }

        public IEnumerable<T> ResolveAll<T>()
        {
            return _container
                .Resolve<IEnumerable<T>>();
        }

        public T ResolveWithContext<T, TContext>(TContext context)
        {
            return _container
                .Resolve<Func<TContext, T>>()(context);
        }

        public TService ResolveKeyedOrAny<TService, TKey>(TKey key)
        {
            return _container
                .ResolveKeyedOrAny<TService, TKey>(key);
        }
        #endregion
    }
}
