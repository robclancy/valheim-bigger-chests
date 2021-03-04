using BepInEx;
using HarmonyLib;

namespace ValheimBiggerChests
{
    [BepInPlugin("org.bepinex.plugins.valheim_bigger_chests", "Valheim Bigger Chests", "0.0.1")]
    class ValheimPlusPlugin : BaseUnityPlugin
    {
        void Awake()
        {
            Logger.LogInfo("Loaded Valheim Bigger Chests.");

            var harmony = new Harmony("mod.valheim_bigger_chests");
            harmony.PatchAll();
        }
    }
}