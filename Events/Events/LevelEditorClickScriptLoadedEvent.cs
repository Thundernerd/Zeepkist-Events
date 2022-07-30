using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    public struct LevelEditorClickScriptLoadedEvent
    {
        public readonly EventMode EventMode;
        public readonly LEV_ClickScript Instance;

        public LevelEditorClickScriptLoadedEvent(EventMode eventMode, LEV_ClickScript instance)
        {
            EventMode = eventMode;
            Instance = instance;
        }
    }
}
