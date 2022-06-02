using BattleTech;
using BattleTech.UI;
using Harmony;
using InControl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BattleTech.Data;
using BattleTech.UI.Tooltips;
using HBS;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BindEnterToMouse.Patches
{
    public class KeyBinding
    {
        public class Adapter<T>
        {
            public readonly T instance;
            public readonly Traverse traverse;

            protected Adapter(T instance)
            {
                this.instance = instance;
                traverse = Traverse.Create(instance);
            }
        }

        [HarmonyPatch(typeof(StaticActions), "CreateWithDefaultBindings")]
        public static class StaticActions_Patch_CreateWDB
        {
            public static void Postfix(ref StaticActions __result)
            {
                __result.Return.ClearBindings();
                __result.Return.AddDefaultBinding(new Key[]
                {
                    Key.Return
                });

                __result.Return.AddDefaultBinding(new MouseBindingSource(Core.Settings.MouseBind));
            }
        }
    }
}