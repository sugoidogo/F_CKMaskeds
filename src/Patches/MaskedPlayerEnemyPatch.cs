using HarmonyLib;

namespace F_CKMaskeds.Patches
{
    [HarmonyPatch(typeof(MaskedPlayerEnemy))]
    internal class MaskedPlayerEnemyPatch
    {
        [HarmonyPatch(typeof(MaskedPlayerEnemy), "Start")]
        [HarmonyPostfix]
        static void fuckMaskedsPatch(MaskedPlayerEnemy __instance)
        {
            __instance.KillEnemyOnOwnerClient();

            //UnityEngine.Object.Destroy(__instance.gameObject);

            string logString = "Masked F_CKED!";
            FuckMaskeds.mls.LogInfo(logString);

            FuckMaskeds.amountFucked++;
            string logAmount = "Total F_CKED masked this session: " + FuckMaskeds.amountFucked;
            FuckMaskeds.mls.LogInfo(logAmount);
        }
    }
}
