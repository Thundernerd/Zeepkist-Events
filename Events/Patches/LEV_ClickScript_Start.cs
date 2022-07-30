using HarmonyLib;
using TNRD.Zeepkist.EventData;
using TNRD.Zeepkist.Events;
using TNRD.Zeepkist.EventSystem;

namespace TNRD.Zeepkist.Patches
{
    [HarmonyPatch(typeof(LEV_ClickScript),"Start")]
    internal class LEV_ClickScript_Start
    {
        private static void Postfix(LEV_ClickScript __instance)
        {
            EventDispatcher.Dispatch(new LevelEditorClickScriptLoadedEvent(EventMode.Postfix, __instance));
        }
    }
}
