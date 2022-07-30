using JetBrains.Annotations;
using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    [PublicAPI]
    public class EnableSmallBoxEvent : ZeepEvent
    {
        public EnableSmallBoxEvent(EventMode eventMode)
            : base(eventMode)
        {
        }
    }
}
