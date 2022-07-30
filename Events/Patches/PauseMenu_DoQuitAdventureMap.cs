using HarmonyLib;
using TNRD.Zeepkist.EventData;
using TNRD.Zeepkist.Events;
using TNRD.Zeepkist.EventSystem;

namespace TNRD.Zeepkist.Patches
{
    [HarmonyPatch(typeof(PauseMenu), nameof(PauseMenu.DoQuitAdventueMap))]
    internal class PauseMenu_DoQuitAdventureMap
    {
        private static void Postfix()
        {
            EventDispatcher.Dispatch(new QuitAdventureMapEvent(EventMode.Postfix));
        }
    }
}
