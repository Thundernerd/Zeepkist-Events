using System;
using System.Collections.Generic;
using TNRD.Zeepkist.Events;

namespace TNRD.Zeepkist.EventSystem
{
    internal static class EventPools
    {
        private static readonly Dictionary<Type, SubscriptionPool>
            typeToPool = new Dictionary<Type, SubscriptionPool>();

        public static void AddToPool<T>(EventData<T> eventData)
            where T : ZeepEvent
        {
            if (!typeToPool.TryGetValue(typeof(T), out SubscriptionPool pool))
            {
                typeToPool.Add(typeof(T), new SubscriptionPool());
            }

            typeToPool[typeof(T)].Add(eventData);
        }

        public static bool RemoveFromPool(Subscription subscription)
        {
            if (!typeToPool.TryGetValue(subscription.Type, out SubscriptionPool pool))
            {
                // Uh oh
                return false;
            }

            return pool.Remove(subscription);
        }

        public static bool TryGetPool<T>(out SubscriptionPool subscriptionPool)
            where T : ZeepEvent
        {
            return typeToPool.TryGetValue(typeof(T), out subscriptionPool);
        }
    }
}
