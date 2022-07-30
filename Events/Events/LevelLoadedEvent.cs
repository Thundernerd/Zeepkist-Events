using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    public readonly struct LevelLoadedEvent
    {
        public readonly GameMode Mode;

        public LevelLoadedEvent(GameMode mode)
        {
            Mode = mode;
        }
    }
}
