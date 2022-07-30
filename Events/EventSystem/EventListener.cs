using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using TNRD.Zeepkist.Events;

namespace TNRD.Zeepkist.EventSystem
{
    [PublicAPI]
    public delegate void OnEventDelegate<in T>(T value);

    [PublicAPI]
    public static class EventListener
    {
        private static readonly Dictionary<Type, SubscriptionPool> typeToPool = new Dictionary<Type, SubscriptionPool>();

        public static Subscription Subscribe<T>(OnEventDelegate<T> callback)
            where T : ZeepEvent
        {
            Subscription subscription = new Subscription(typeof(T));
            EventData<T> eventData = new EventData<T>(subscription, callback);
            EventPools.AddToPool(eventData);
            return subscription;
        }

        public static bool Unsubscribe(Subscription subscription)
        {
            return EventPools.RemoveFromPool(subscription);
        }
    }
}
