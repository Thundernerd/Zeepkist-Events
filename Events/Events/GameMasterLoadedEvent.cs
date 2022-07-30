using JetBrains.Annotations;
using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    [PublicAPI]
    public class GameMasterLoadedEvent : ZeepEvent
    {
        public readonly GameMaster GameMaster;

        public GameMasterLoadedEvent(EventMode eventMode, GameMaster gameMaster)
            : base(eventMode)
        {
            GameMaster = gameMaster;
        }
    }
}
