using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpSynthesis.Core.Domain;

namespace SpSynthesis.Domain
{
    /// <summary>
    /// Class Unit
    /// </summary>
    public class Creature : Entity<Creature>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Creature" /> class.
        /// </summary>
        public Creature()
        {
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>The image.</value>
        public byte[] Image { get; set; }
        /// <summary>
        /// Gets or sets the leadership.
        /// </summary>
        /// <value>The leadership.</value>
        public int Leadership { get; set; }
        /// <summary>
        /// Gets or sets the health.
        /// </summary>
        /// <value>The health.</value>
        public int Health { get; set; }

        #region Damage Properties
        /// <summary>
        /// Gets or sets the min damage.
        /// </summary>
        /// <value>The min damage.</value>
        public int MinDamage { get; set; }
        /// <summary>
        /// Gets or sets the max damage.
        /// </summary>
        /// <value>The max damage.</value>
        public int MaxDamage { get; set; }
        #endregion

        /// <summary>
        /// Gets or sets the range.
        /// </summary>
        /// <value>The range.</value>
        public int Range { get; set; }
        /// <summary>
        /// Gets or sets the attack.
        /// </summary>
        /// <value>The attack.</value>
        public int Attack { get; set; }
        /// <summary>
        /// Gets or sets the defence.
        /// </summary>
        /// <value>The defence.</value>
        public int Defence { get; set; }
        /// <summary>
        /// Gets or sets the initiative.
        /// </summary>
        /// <value>The initiative.</value>
        public int Initiative { get; set; }
        /// <summary>
        /// Gets or sets the speed.
        /// </summary>
        /// <value>The speed.</value>
        public int Speed { get; set; }
        /// <summary>
        /// Gets or sets the critical hit.
        /// </summary>
        /// <value>The critical hit.</value>
        public int CriticalHit { get; set; }

        #region Resistance properties
        /// <summary>
        /// Gets or sets the F resistance.
        /// </summary>
        /// <value>The F resistance.</value>
        public int FResistance { get; set; }
        /// <summary>
        /// Gets or sets the A resistance.
        /// </summary>
        /// <value>The A resistance.</value>
        public int AResistance { get; set; }
        /// <summary>
        /// Gets or sets the M resistance.
        /// </summary>
        /// <value>The M resistance.</value>
        public int MResistance { get; set; }
        #endregion
    }
}
