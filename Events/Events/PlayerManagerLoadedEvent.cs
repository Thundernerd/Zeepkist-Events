using JetBrains.Annotations;
using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    [PublicAPI]
    public class PlayerManagerLoadedEvent : ZeepEvent
    {
        public readonly PlayerManager PlayerManager;

        public PlayerManagerLoadedEvent(EventMode eventMode, PlayerManager playerManager)
            : base(eventMode)
        {
            PlayerManager = playerManager;
        }
    }
}
