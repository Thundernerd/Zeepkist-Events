using HarmonyLib;
using TNRD.Zeepkist.EventData;
using TNRD.Zeepkist.Events;
using TNRD.Zeepkist.EventSystem;

namespace TNRD.Zeepkist.Patches
{
    [HarmonyPatch(typeof(GeneralLevelLoader), nameof(GeneralLevelLoader.PrimeForGameplay))]
    internal class GeneralLevelLoader_PrimeForGameplay
    {
        private static void Postfix(GameMaster theMaster, string[] theLines, SkyboxManager theSkybox)
        {
            EventDispatcher.Dispatch(new LevelLoadedEvent(EventMode.Postfix, GameMode.Game));
        }
    }
}
