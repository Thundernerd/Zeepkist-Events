using JetBrains.Annotations;
using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    [PublicAPI]
    public class LevelEditorCameraLoadedEvent : ZeepEvent
    {
        public readonly LEV_MoveCamera MoveCamera;

        public LevelEditorCameraLoadedEvent(EventMode eventMode, LEV_MoveCamera moveCamera)
            : base(eventMode)
        {
            MoveCamera = moveCamera;
        }
    }
}
