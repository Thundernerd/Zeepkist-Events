using HarmonyLib;
using TNRD.Zeepkist.EventData;
using TNRD.Zeepkist.Events;
using TNRD.Zeepkist.EventSystem;

namespace TNRD.Zeepkist.Patches
{
    [HarmonyPatch(typeof(GeneralLevelLoader), nameof(GeneralLevelLoader.PrimeForLevelEditor))]
    internal class GeneralLevelLoader_PrimeForLevelEditor
    {
        private static void Postfix(LEV_LevelEditorCentral theCentral, string[] theLines, SkyboxManager theSkybox)
        {
            EventDispatcher.Dispatch(new LevelLoadedEvent(EventMode.Postfix, GameMode.Editor));
        }
    }
}
