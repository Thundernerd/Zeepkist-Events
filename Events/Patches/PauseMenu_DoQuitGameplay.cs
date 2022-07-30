using HarmonyLib;
using TNRD.Zeepkist.EventData;
using TNRD.Zeepkist.Events;
using TNRD.Zeepkist.EventSystem;

namespace TNRD.Zeepkist.Patches
{
    [HarmonyPatch(typeof(PauseMenu), nameof(PauseMenu.DoQuitGameplay))]
    internal class PauseMenu_DoQuitGameplay
    {
        private static void Postfix()
        {
            EventDispatcher.Dispatch(new QuitGameplayEvent(EventMode.Postfix));
        }
    }
}
