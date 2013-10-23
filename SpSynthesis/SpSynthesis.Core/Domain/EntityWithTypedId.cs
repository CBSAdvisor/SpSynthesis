// ***********************************************************************
// Assembly         : SpSynthesis.Core
// Created          : 10-23-2013
//
// Last Modified On : 10-23-2013
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpSynthesis.Core.Domain
{
    /// <summary>
    /// Class EntityWithTypedId
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TId">The type of the T id.</typeparam>
    [Serializable]
    public class EntityWithTypedId<T, TId>
        where T : EntityWithTypedId<T, TId>
    {
        #region Data

        /// <summary>
        /// The old hash code
        /// </summary>
        private int? oldHashCode;

        #endregion

        #region Methods

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            T other = obj as T;
            return Equals(other);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            //This is done se we won't change the hash code 

            if (oldHashCode.HasValue)
            {
                return oldHashCode.Value;
            }

            // if (thisIsTransient)
            if (IsTransient())
            {
                oldHashCode = base.GetHashCode();
                return oldHashCode.Value;
            }

            return Id.GetHashCode();
        }

        #endregion Methods

        #region IEquatable<T> Members

        /// <summary>
        /// Equalses the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        public virtual bool Equals(T other)
        {
            if ((object)other == null)
            {
                return false;
            }

            bool otherIsTransient = Equals(other.Id, default(TId));

            bool thisIsTransient = Equals(this.Id, default(TId));

            if (otherIsTransient && thisIsTransient)
            {
                return ReferenceEquals(other, this);
            }

            return other.Id.Equals(Id);
        }

        #endregion

        #region IEntityWithTypedId<TId> Members

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public virtual TId Id
        {
            get;
            protected set;
        }

        /// <summary>
        /// Determines whether this instance is transient.
        /// </summary>
        /// <returns><c>true</c> if this instance is transient; otherwise, <c>false</c>.</returns>
        public virtual bool IsTransient()
        {
            return Id.Equals(default(TId));
        }

        #endregion

        #region Operators

        /// <summary>
        /// Implements the ==.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(EntityWithTypedId<T, TId> x, EntityWithTypedId<T, TId> y)
        {
            return Equals(x, y);
        }

        /// <summary>
        /// Implements the !=.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(EntityWithTypedId<T, TId> x, EntityWithTypedId<T, TId> y)
        {
            return !(x == y);
        }

        #endregion
    }
}
