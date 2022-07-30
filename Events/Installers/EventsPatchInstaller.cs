using HarmonyLib;

namespace TNRD.Zeepkist.Installers
{
    public static class EventsPatchInstaller
    {
        public static void PatchEvents(this Harmony harmony)
        {
            harmony.PatchAll(typeof(EventsPatchInstaller).Assembly);
        }
    }
}
