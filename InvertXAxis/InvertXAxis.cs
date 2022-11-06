using HarmonyLib;
using OWML.Common;
using OWML.ModHelper;
using System.Reflection;


namespace InvertXAxis
{
    public class InvertXAxis : ModBehaviour
    {
        public static InvertXAxis Instance;

        private void Start()
        {
            ModHelper.Console.WriteLine($"[ {nameof(InvertXAxis)} ] Mod loaded!", MessageType.Success);
            Instance = this;
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        }

    }
}
