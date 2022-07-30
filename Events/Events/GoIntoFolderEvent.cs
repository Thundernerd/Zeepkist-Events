using JetBrains.Annotations;
using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    [PublicAPI]
    public class GoIntoFolderEvent : ZeepEvent
    {
        public readonly LevelIndex.DirectoryOrLevel Folder;
        public readonly bool ResetCard;

        public GoIntoFolderEvent(EventMode eventMode, ref LevelIndex.DirectoryOrLevel folder, ref bool resetCard)
            : base(eventMode)
        {
            Folder = folder;
            ResetCard = resetCard;
        }
    }
}
