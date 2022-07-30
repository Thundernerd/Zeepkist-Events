using HarmonyLib;
using TNRD.Zeepkist.EventData;
using TNRD.Zeepkist.Events;
using TNRD.Zeepkist.EventSystem;

namespace TNRD.Zeepkist.Patches
{
    [HarmonyPatch(typeof(SetupGame), "Awake")]
    internal class SetupGame_Awake
    {
        private static void Postfix(SetupGame __instance)
        {
            EventDispatcher.Dispatch(new SetupGameLoadedEvent(EventMode.Postfix, __instance));
        }
    }
}
