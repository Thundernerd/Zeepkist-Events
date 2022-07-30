using JetBrains.Annotations;
using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    [PublicAPI]
    public class QuitGameplayEvent : ZeepEvent
    {
        public QuitGameplayEvent(EventMode eventMode)
            : base(eventMode)
        {
        }
    }
}
