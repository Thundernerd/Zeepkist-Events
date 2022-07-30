using JetBrains.Annotations;
using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    [PublicAPI]
    public class QuitAdventureMapEvent : ZeepEvent
    {
        public QuitAdventureMapEvent(EventMode eventMode)
            : base(eventMode)
        {
        }
    }
}
