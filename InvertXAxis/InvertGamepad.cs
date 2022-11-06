using HarmonyLib;
using OWML.Common;
using UnityEngine.InputSystem;


[HarmonyPatch]
public class InvertGamepad
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Gamepad), "FinishSetup")]
    public static void Gamepad_FinishSetUp_Postfix(Gamepad __instance)
    {
        // Player Axis
        __instance.rightStick.x.invert = true;
        //__instance.rightStick.y.invert = true;

        // Ship Axis
        //__instance.rightStick.up.invert = true;
        //__instance.rightStick.down.invert = false;
        __instance.rightStick.right.invert = true;
        __instance.rightStick.left.invert = false;
        InvertXAxis.InvertXAxis.Instance.ModHelper.Console.WriteLine(
           $"[ {nameof(InvertXAxis)} ] Keybindings set! -> {__instance.displayName}", MessageType.Success);
    }
}
