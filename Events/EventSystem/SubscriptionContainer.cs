using System.Collections.Generic;
using JetBrains.Annotations;

namespace TNRD.Zeepkist.EventSystem
{
    [PublicAPI]
    public class SubscriptionContainer
    {
        private readonly List<Subscription> subscriptions = new List<Subscription>();

        public SubscriptionContainer(params Subscription[] subscriptions)
        {
            this.subscriptions.AddRange(subscriptions);
        }
    
        public SubscriptionContainer Add(Subscription subscription)
        {
            subscriptions.Add(subscription);
            return this;
        }
    
        public void UnsubscribeAll()
        {
            foreach (Subscription subscription in subscriptions)
            {
                EventListener.Unsubscribe(subscription);
            }
        }
    }
}
