using HarmonyLib;

namespace ValheimBiggerChests
{
    [HarmonyPatch(typeof(Container), "Awake")]
    public static class ApplyContainerSizeChanges
    {
        private static void Prefix(ref Container __instance)
        {
            applyContainerSizes(__instance);
        }

        private static void applyContainerSizes(Container instance)
        {
            if (instance.m_wagon)
            {
                instance.m_width = 8;
                instance.m_height = 4;

                return;
            }

            Ship ship = instance.gameObject.transform.parent?.GetComponent<Ship>();

            if (ship)
            {
                if (ship.name.StartsWith("VikingShip"))
                {
                    instance.m_width = 7;
                    instance.m_height = 4;

                    return;
                }

                if (ship.name.StartsWith("Karve"))
                {
                    instance.m_width = 3;
                    instance.m_height = 3;

                    return;
                }

                return;
            }

            if (instance.name.StartsWith("piece_chest_wood"))
            {
                instance.m_height = 3;

                return;
            }

            if (instance.name.StartsWith("piece_chest_private"))
            {
                instance.m_width = 5;

                return;
            }

            if (instance.name.StartsWith("piece_chest"))
            {
                instance.m_width = 7;
                instance.m_height = 4;

                return;
            }
        }
    }

    [HarmonyPatch(typeof(Container), "GetHoverText")]
    public static class DebugHoverText
    {
        private static void Postfix(ref Container __instance, ref string __result)
        {
            //Ship ship = __instance.gameObject.transform.parent?.GetComponent<Ship>();

            //if (ship)
            //{
            //    __result = ship.name;
            //}
            //else {
            //    __result = __instance.name;
            //}
        }
    }


}
