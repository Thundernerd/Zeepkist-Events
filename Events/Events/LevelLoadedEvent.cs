using JetBrains.Annotations;
using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    [PublicAPI]
    public class LevelLoadedEvent : ZeepEvent
    {
        public readonly GameMode Mode;

        public LevelLoadedEvent(EventMode eventMode, GameMode mode) : base(eventMode)
        {
            Mode = mode;
        }
    }
}
