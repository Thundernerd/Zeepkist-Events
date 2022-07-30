using TNRD.Zeepkist.Events;

namespace TNRD.Zeepkist.EventSystem
{
    internal class EventDispatcher
    {
        public static void Dispatch<T>(T data)
            where T : ZeepEvent
        {
            if (!EventPools.TryGetPool<T>(out SubscriptionPool pool))
            {
                return;
            }

            pool.Invoke(data);
        }
    }
}
