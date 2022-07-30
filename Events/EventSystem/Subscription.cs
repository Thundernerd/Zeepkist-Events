using System;
using JetBrains.Annotations;

namespace TNRD.Zeepkist.EventSystem
{
    [PublicAPI]
    public class Subscription : IEquatable<Subscription>
    {
        public Guid Guid { get; }

        public Type Type { get; }

        public Subscription(Type type)
        {
            Type = type;
            Guid = Guid.NewGuid();
        }

        /// <inheritdoc />
        public bool Equals(Subscription other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Guid.Equals(other.Guid);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Subscription)obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Guid.GetHashCode();
        }
    }
}
