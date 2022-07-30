using HarmonyLib;
using JetBrains.Annotations;

namespace TNRD.Zeepkist.Installers
{
    [PublicAPI]
    public static class EventsPatchInstaller
    {
        public static void PatchEvents(this Harmony harmony)
        {
            harmony.PatchAll(typeof(EventsPatchInstaller).Assembly);
        }
    }
}
