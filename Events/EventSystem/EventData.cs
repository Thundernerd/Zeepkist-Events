using System;
using TNRD.Zeepkist.Events;

namespace TNRD.Zeepkist.EventSystem
{
    internal abstract class EventData : IEquatable<EventData>
    {
        public readonly Subscription Subscription;
        public readonly Type Type;

        protected EventData(Subscription subscription, Type type)
        {
            Subscription = subscription;
            Type = type;
        }

        public abstract void Invoke(object data);

        /// <inheritdoc />
        public bool Equals(EventData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(Subscription, other.Subscription);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((EventData)obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return (Subscription != null ? Subscription.GetHashCode() : 0);
        }
    }

    internal class EventData<T> : EventData
        where T : ZeepEvent
    {
        private readonly OnEventDelegate<T> callback;

        public EventData(Subscription subscription, OnEventDelegate<T> callback)
            : base(subscription, typeof(T))
        {
            this.callback = callback;
        }

        /// <inheritdoc />
        public override void Invoke(object data)
        {
            if (data is T converted)
            {
                callback.Invoke(converted);
            }
        }
    }
}
