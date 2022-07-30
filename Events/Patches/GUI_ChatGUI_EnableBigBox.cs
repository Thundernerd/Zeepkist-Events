using HarmonyLib;
using TNRD.Zeepkist.EventData;
using TNRD.Zeepkist.Events;
using TNRD.Zeepkist.EventSystem;

namespace TNRD.Zeepkist.Patches
{
    [HarmonyPatch(typeof(GUI_ChatGUI), "EnableBigBox")]
    internal class GUI_ChatGUI_EnableBigBox
    {
        private static void Postfix()
        {
            EventDispatcher.Dispatch(new EnableBigBoxEvent(EventMode.Postfix));
        }
    }
}
