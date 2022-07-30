using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    public readonly struct GameMasterLoadedEvent
    {
        public readonly EventMode EventMode;
        public readonly GameMaster GameMaster;

        public GameMasterLoadedEvent(EventMode eventMode, GameMaster gameMaster)
        {
            EventMode = eventMode;
            GameMaster = gameMaster;
        }
    }
}
