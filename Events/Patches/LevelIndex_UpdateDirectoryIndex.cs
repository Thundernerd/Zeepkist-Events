using HarmonyLib;
using TNRD.Zeepkist.EventData;
using TNRD.Zeepkist.Events;
using TNRD.Zeepkist.EventSystem;

namespace TNRD.Zeepkist.Patches
{
    [HarmonyPatch(typeof(LevelIndex), "UpdateDirectoryIndex")]
    internal class LevelIndex_UpdateDirectoryIndex
    {
        private static void Prefix(bool updateLevels, bool updateWorkshop)
        {
            EventDispatcher.Dispatch(new DirectoryIndexUpdatedEvent(EventMode.Prefix, updateLevels, updateWorkshop));
        }

        private static void Postfix(bool updateLevels, bool updateWorkshop)
        {
            EventDispatcher.Dispatch(new DirectoryIndexUpdatedEvent(EventMode.Postfix, updateLevels, updateWorkshop));
        }
    }
}
