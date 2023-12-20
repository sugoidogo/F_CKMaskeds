using BepInEx;
using BepInEx.Logging;
using F_CKMaskeds.Patches;
using HarmonyLib;

namespace F_CKMaskeds
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class FuckMaskeds : BaseUnityPlugin
    {
        private const string modGUID = "SugoiDogo.F_CKMaskeds";
        private const string modName = "F_CKMaskeds";
        private const string modVersion = "1.0.2";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static FuckMaskeds Instance;

        public static int amountFucked = 0;

        internal static ManualLogSource mls;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("F_CK Maskeds!!!");

            harmony.PatchAll(typeof(FuckMaskeds));
            harmony.PatchAll(typeof(MaskedPlayerEnemyPatch));
        }
    }
}
