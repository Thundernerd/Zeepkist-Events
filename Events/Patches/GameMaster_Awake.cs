using HarmonyLib;
using TNRD.Zeepkist.EventData;
using TNRD.Zeepkist.Events;
using TNRD.Zeepkist.EventSystem;

namespace TNRD.Zeepkist.Patches
{
    [HarmonyPatch(typeof(GameMaster), "Awake")]
    internal class GameMaster_Awake
    {
        private static void Prefix(GameMaster __instance)
        {
            EventDispatcher.Dispatch(new GameMasterLoadedEvent(EventMode.Prefix, __instance));
        }

        private static void Postfix(GameMaster __instance)
        {
            EventDispatcher.Dispatch(new GameMasterLoadedEvent(EventMode.Postfix, __instance));
        }
    }
}
