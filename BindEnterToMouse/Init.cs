using Harmony;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BindEnterToMouse
{
    public static class HarmonyInit
    {
        public static void Init(string directory, string settingsJSON)
        {

            try
            {
                Core.Settings = JsonConvert.DeserializeObject<ModSettings>(settingsJSON);

                var harmony = HarmonyInstance.Create("io.github.nbk_redspy.BindEnterToMouse");
                harmony.PatchAll(Assembly.GetExecutingAssembly());
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                throw;
            }        }
    }
}
