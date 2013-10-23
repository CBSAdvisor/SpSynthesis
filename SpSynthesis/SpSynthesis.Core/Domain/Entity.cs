using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpSynthesis.Core.Domain
{
    [Serializable]
    public class Entity<T> : EntityWithTypedId<T, Guid>
        where T : Entity<T>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
