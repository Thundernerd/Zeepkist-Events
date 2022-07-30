using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    public struct SelectNextLevelMenuBeginEvent
    {
        public readonly EventMode EventMode;
        public readonly SelectNextLevelMenu Instance;

        public SelectNextLevelMenuBeginEvent(EventMode eventMode,SelectNextLevelMenu instance)
        {
            EventMode = eventMode;
            Instance = instance;
        }
    }
}
