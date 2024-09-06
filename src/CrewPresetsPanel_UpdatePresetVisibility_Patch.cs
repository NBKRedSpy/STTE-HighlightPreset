using HarmonyLib;
using RST.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace HighlightPreset
{
    [HarmonyPatch(typeof(CrewPresetsPanel), nameof(CrewPresetsPanel.UpdatePresetVisibility))]
    public static class CrewPresetsPanel_UpdatePresetVisibility_Patch
    {
        public static void Postfix(CrewPresetsPanel __instance)
        {
            foreach (var preset in __instance.presets)
            {
                if(preset != null)
                {
                    preset.highlight.GetComponent<Graphic>().color = Plugin.HighlightColor;
                }
            }
            
        }
    }

}
