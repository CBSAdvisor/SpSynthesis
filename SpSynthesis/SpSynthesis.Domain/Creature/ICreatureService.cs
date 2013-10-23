using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpSynthesis.Domain
{
    /// <summary>
    /// Interface ICreatureService
    /// </summary>
    public interface ICreatureService
    {
        /// <summary>
        /// Loads all.
        /// </summary>
        /// <returns>IEnumerable{Unit}.</returns>
        IEnumerable<Creature> LoadAll();

        /// <summary>
        /// Inserts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Insert(Creature entity);
    }
}
