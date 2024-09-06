using BepInEx;
using BepInEx.Logging;

namespace ForceSafetyMode
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class SafetyMode : BaseUnityPlugin
    {
        SafetyMode()
        {
            HarmonyPatches.ApplyHarmonyPatches();
        }
    }
}