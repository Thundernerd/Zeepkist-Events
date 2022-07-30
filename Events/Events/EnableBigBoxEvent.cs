using JetBrains.Annotations;
using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    [PublicAPI]
    public class EnableBigBoxEvent : ZeepEvent
    {
        public EnableBigBoxEvent(EventMode eventMode)
            : base(eventMode)

        {
        }
    }
}
