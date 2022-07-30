using HarmonyLib;
using TNRD.Zeepkist.Events;
using TNRD.Zeepkist.EventSystem;

namespace TNRD.Zeepkist.Patches
{
    [HarmonyPatch(typeof(PlayerManager), "Awake")]
    internal class PlayerManager_Awake
    {
        private static void Postfix(PlayerManager __instance)
        {
            EventDispatcher.Dispatch(new PlayerManagerLoadedEvent(__instance)); 
        }
    }
}
