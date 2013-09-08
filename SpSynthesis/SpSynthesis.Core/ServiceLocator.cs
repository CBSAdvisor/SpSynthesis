using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpFlyVoices.Core
{
    public static class ServiceLocator
    {
        // [ThreadStatic]
        private static Func<IServiceProvider> _provider;

        public static void Initialize(Func<IServiceProvider> provider)
        {
            _provider = provider;
        }

        public static T Resolve<T>()
        {
            return _provider().ResolveInstance<T>();
        }

        public static object Resolve(Type service)
        {
            return _provider().ResolveInstance(service);
        }

        public static IEnumerable<T> ResolveAll<T>()
        {
            return _provider().ResolveAll<T>();
        }

        public static T ResolveWithContext<T, TContext>(TContext context)
        {
            return _provider().ResolveWithContext<T, TContext>(context);

        }
    }
}
