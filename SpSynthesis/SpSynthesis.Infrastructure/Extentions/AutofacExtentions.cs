using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace SpSynthesis.Infrastructure.Extentions
{
    public static class AutofacExtentions
    {
        public static TService ResolveKeyedOrAny<TService, TKey>(this IComponentContext instance, TKey key)
        {
            object service = null;
            return instance.TryResolveKeyed(key, typeof(TService), out service)
                ? (TService)service
                : instance.Resolve<TService>();
        }
    }
}
