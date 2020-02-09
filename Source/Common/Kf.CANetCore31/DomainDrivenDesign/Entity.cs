using Kf.CANetCore31.Diagnostics;
using System;
using System.Diagnostics;

namespace Kf.CANetCore31.DomainDrivenDesign
{
    /// <summary>
    /// Defines an entity.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplayString,nq}")]
    public abstract class Entity
        : IDebuggerDisplayString,
          IEquatable<Entity>
    {
        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
            => !(a == b);

        protected Entity(long id)
            => Id = id;

        public long Id { get; }

        public override bool Equals(object @object)
        {
            if (@object == null) return false;
            if (@object is Entity entity) return Equals(entity);
            return false;
        }

        public bool Equals(Entity other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            if (GetType() != other.GetType()) return false;
            return Id == other.Id;
        }

        public override int GetHashCode()
            => $"{GetType()}{Id}".GetHashCode();

        public virtual string DebuggerDisplayString
            => this.CreateDebugString(x => x.Id);

        public override string ToString()
            => DebuggerDisplayString;
    }
}
