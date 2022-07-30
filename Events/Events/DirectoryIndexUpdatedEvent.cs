using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    public readonly struct DirectoryIndexUpdatedEvent
    {
        public readonly EventMode EventMode;
        public readonly bool UpdateLevels;
        public readonly bool UpdateWorkshop;

        public DirectoryIndexUpdatedEvent(EventMode eventMode, bool updateLevels, bool updateWorkshop)
        {
            EventMode = eventMode;
            UpdateLevels = updateLevels;
            UpdateWorkshop = updateWorkshop;
        }
    }
}
