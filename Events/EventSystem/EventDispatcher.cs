using System;

namespace TNRD.Zeepkist.EventSystem
{
    public class EventDispatcher
    {
        public static void Dispatch<T>()
            where T : struct
        {
            Dispatch(new T());
        }

        public static void Dispatch<T>(params object[] parameters)
            where T : struct
        {
            T instance = (T)Activator.CreateInstance(typeof(T), parameters);
            Dispatch<T>(instance);
        }

        public static void Dispatch<T>(T data)
            where T : struct
        {
            if (!EventPools.TryGetPool<T>(out SubscriptionPool pool))
            {
                return;
            }

            pool.Invoke(data);
        }
    }
}
