using System.Collections.Generic;

namespace TNRD.Zeepkist.EventSystem
{
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
