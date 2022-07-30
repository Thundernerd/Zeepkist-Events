using JetBrains.Annotations;
using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    [PublicAPI]
    public class SetupGameLoadedEvent : ZeepEvent
    {
        public readonly SetupGame SetupGame;

        public SetupGameLoadedEvent(EventMode eventMode, SetupGame setupGame)
            : base(eventMode)
        {
            SetupGame = setupGame;
        }
    }
}
