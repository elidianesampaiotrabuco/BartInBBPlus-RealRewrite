using BartInBBPlus;
using BepInEx;

using HarmonyLib;

using ThinkerAPI;

namespace BartInBBPlus
{
    [BepInPlugin("starrie.bbplus.bart", "Bart in BB+", "2.0.0.0")]

    [BepInDependency("thinkerAPI")]

    public class BasePlugin : BaseUnityPlugin
    {
        public void Awake()
        {
            Harmony harmony = new Harmony("starrie.bbplus.bart");

            bool flag = BasePlugin.Instance == null;
            if (flag)
            {
                BasePlugin.Instance = this;
            }
        }
    public static BasePlugin Instance;
    }
    }