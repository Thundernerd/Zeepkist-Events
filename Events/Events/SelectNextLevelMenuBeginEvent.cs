using JetBrains.Annotations;
using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    [PublicAPI]
    public class SelectNextLevelMenuBeginEvent : ZeepEvent
    {
        public readonly SelectNextLevelMenu Instance;

        public SelectNextLevelMenuBeginEvent(EventMode eventMode, SelectNextLevelMenu instance)
            : base(eventMode)
        {
            Instance = instance;
        }
    }
}
