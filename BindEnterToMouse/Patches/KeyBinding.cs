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

        [HarmonyPatch(typeof(StaticActions), "CreateWithDefaultBindings")]
        public static class StaticActions_Patch_CreateWDB
        {
            public static void Postfix(ref StaticActions __result)
            {

                try
                {

                    if (Core.Settings.EnterMouseBind != Mouse.None)
                    {
                        //--- Enter
                        __result.Return.ClearBindings();
                        __result.Return.AddDefaultBinding(new Key[]
                        {
                            Key.Return
                        });

                        __result.Return.AddDefaultBinding(new MouseBindingSource(Core.Settings.EnterMouseBind));
                    }

                    if (Core.Settings.EscapeMouseBind != Mouse.None)
                    {
                        //--- Escape
                        __result.Escape.ClearBindings();
                        __result.Escape.AddDefaultBinding(new Key[]
                        {
                        Key.Escape
                        });

                        __result.Escape.AddDefaultBinding(new MouseBindingSource(Core.Settings.EscapeMouseBind));
                    }

                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                }
                


            }

        }

        
    }
}