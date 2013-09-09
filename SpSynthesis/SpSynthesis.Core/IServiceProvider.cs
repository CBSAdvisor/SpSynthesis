using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpSynthesis.Core
{
    public interface IServiceProvider
    {
        T ResolveInstance<T>();

        object ResolveInstance(Type service);

        IEnumerable<T> ResolveAll<T>();

        T ResolveWithContext<T, TContext>(TContext context);

        TService ResolveKeyedOrAny<TService, TKey>(TKey key);
    }
}
