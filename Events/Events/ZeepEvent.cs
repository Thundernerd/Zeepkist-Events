using JetBrains.Annotations;
using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    [PublicAPI]
    public abstract class ZeepEvent
    {
        public readonly EventMode EventMode;

        protected ZeepEvent(EventMode eventMode)
        {
            EventMode = eventMode;
        }
    }
}
