using HarmonyLib;
using TNRD.Zeepkist.EventData;
using TNRD.Zeepkist.Events;
using TNRD.Zeepkist.EventSystem;

namespace TNRD.Zeepkist.Patches
{
    [HarmonyPatch(typeof(SelectNextLevelMenu), nameof(SelectNextLevelMenu.Begin))]
    internal class SelectNextLevelMenu_Begin
    {
        private static void Prefix(SelectNextLevelMenu __instance)
        {
            EventDispatcher.Dispatch(new SelectNextLevelMenuBeginEvent(EventMode.Prefix, __instance));
        }

        private static void Postfix(SelectNextLevelMenu __instance)
        {
            EventDispatcher.Dispatch(new SelectNextLevelMenuBeginEvent(EventMode.Postfix, __instance));
        }
    }
}
