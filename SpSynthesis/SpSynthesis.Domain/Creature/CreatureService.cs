using SpSynthesis.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpSynthesis.Domain
{
    /// <summary>
    /// Class CreatureService
    /// </summary>
    public class CreatureService : ICreatureService
    {
        /// <summary>
        /// The _creature repository
        /// </summary>
        private ICreatureRepository _creatureRepository;
        /// <summary>
        /// The _unit of work
        /// </summary>
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitService" /> class.
        /// </summary>
        /// <param name="creatureRepository">The creature repository.</param>
        /// <param name="unitOfWork">The unit of work.</param>
        public CreatureService(ICreatureRepository creatureRepository, IUnitOfWork unitOfWork)
        {
            _creatureRepository = creatureRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Loads all.
        /// </summary>
        /// <returns>IEnumerable{Unit}.</returns>
        public IEnumerable<Creature> LoadAll()
        {
            return _creatureRepository.GetAll();
        }

        /// <summary>
        /// Inserts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Insert(Creature entity)
        {
            _creatureRepository.Insert(entity);
            _unitOfWork.Commit();
        }
    }
}
