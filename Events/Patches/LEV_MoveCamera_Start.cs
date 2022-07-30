using HarmonyLib;
using TNRD.Zeepkist.EventData;
using TNRD.Zeepkist.Events;
using TNRD.Zeepkist.EventSystem;

namespace TNRD.Zeepkist.Patches
{
    [HarmonyPatch(typeof(LEV_MoveCamera), "Start")]
    internal class LEV_MoveCamera_Start
    {
        private static void Prefix(LEV_MoveCamera __instance)
        {
            EventDispatcher.Dispatch(new LevelEditorCameraLoadedEvent(EventMode.Prefix, __instance));
        }

        private static void Postfix(LEV_MoveCamera __instance)
        {
            EventDispatcher.Dispatch(new LevelEditorCameraLoadedEvent(EventMode.Postfix, __instance));
        }
    }
}
