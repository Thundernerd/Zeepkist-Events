using JetBrains.Annotations;
using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    [PublicAPI]
    public class DirectoryIndexUpdatedEvent : ZeepEvent
    {
        public readonly bool UpdateLevels;
        public readonly bool UpdateWorkshop;

        public DirectoryIndexUpdatedEvent(EventMode eventMode, bool updateLevels, bool updateWorkshop)
        :base(eventMode)
        {
            UpdateLevels = updateLevels;
            UpdateWorkshop = updateWorkshop;
        }
    }
}
