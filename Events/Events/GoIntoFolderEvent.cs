using TNRD.Zeepkist.EventData;

namespace TNRD.Zeepkist.Events
{
    public readonly struct GoIntoFolderEvent
    {
        public readonly EventMode EventMode;
        public readonly LevelIndex.DirectoryOrLevel Folder;
        public readonly bool ResetCard;

        public GoIntoFolderEvent(EventMode eventMode, ref LevelIndex.DirectoryOrLevel folder, ref bool resetCard)
        {
            EventMode = eventMode;
            Folder = folder;
            ResetCard = resetCard;
        }
    }
}
