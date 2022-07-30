using BepInEx;

namespace TNRD.Zeepkist
{
    [BepInPlugin("net.tnrd.zeepkist.events", "net.tnrd.zeepkist.events", "1.1.0")]
    public class PluginLoader : BaseUnityPlugin
    {
        private void Awake()
        {
            Logger.LogInfo("Plugin net.tnrd.zeepkist.events is loaded!");
        }
    }
}
