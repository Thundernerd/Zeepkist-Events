using HarmonyLib;
using TNRD.Zeepkist.EventData;
using TNRD.Zeepkist.Events;
using TNRD.Zeepkist.EventSystem;

namespace TNRD.Zeepkist.Patches
{
    [HarmonyPatch(typeof(GUI_ChatGUI), nameof(GUI_ChatGUI.EnableSmallBox))]
    internal class GUI_ChatGUI_EnableSmallBox
    {
        private static void Postfix()
        {
            EventDispatcher.Dispatch(new EnableSmallBoxEvent(EventMode.Postfix));
        }
    }
}
