using HarmonyLib;
using TNRD.Zeepkist.EventData;
using TNRD.Zeepkist.Events;
using TNRD.Zeepkist.EventSystem;

namespace TNRD.Zeepkist.Patches
{
    [HarmonyPatch(typeof(SelectNextLevelMenu), "GoIntoFolder")]
    internal class SelectNextLevelMenu_GoIntoFolder
    {
        private static void Prefix(ref LevelIndex.DirectoryOrLevel folder, ref bool resetCard)
        {
            EventDispatcher.Dispatch(new GoIntoFolderEvent(EventMode.Prefix, ref folder, ref resetCard));
        }
        
        private static void Postfix(ref LevelIndex.DirectoryOrLevel folder, ref bool resetCard)
        {
            EventDispatcher.Dispatch(new GoIntoFolderEvent(EventMode.Postfix, ref folder, ref resetCard));
        }
    }
}
