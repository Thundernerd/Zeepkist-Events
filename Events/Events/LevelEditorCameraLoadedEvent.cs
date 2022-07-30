using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    public readonly struct LevelEditorCameraLoadedEvent
    {
        public readonly EventMode EventMode;
        public readonly LEV_MoveCamera MoveCamera;

        public LevelEditorCameraLoadedEvent(EventMode eventMode, LEV_MoveCamera moveCamera)
        {
            EventMode = eventMode;
            MoveCamera = moveCamera;
        }
    }
}
