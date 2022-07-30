using JetBrains.Annotations;
using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    [PublicAPI]
    public class LevelEditorClickScriptLoadedEvent : ZeepEvent
    {
        public readonly LEV_ClickScript Instance;

        public LevelEditorClickScriptLoadedEvent(EventMode eventMode, LEV_ClickScript instance)
            : base(eventMode)
        {
            Instance = instance;
        }
    }
}
