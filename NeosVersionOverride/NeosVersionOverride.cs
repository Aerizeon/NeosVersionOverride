using BaseX;
using CloudX.Shared;
using FrooxEngine;
using FrooxEngine.UIX;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NeosVersionOverride
{
    [Category("Epsilion")]
    public class NeosVersionOverride : Component, ICustomInspector
    {
        private HarmonyLib.Harmony Harmony = new HarmonyLib.Harmony("net.aerizeon.NeosVersionOverride");

        public void BuildInspectorUI(UIBuilder ui)
        {
            WorkerInspector.BuildInspectorUI(this, ui);
            ui.PushStyle();
            ui.Style.MinHeight = 60f;
            ui.Text("This component is to be used for testing only.\nPlease do not include it in any public distributions.\nMessage Epsilion for more details.", true, Alignment.TopCenter);
            ui.PopStyle();
        }

        protected override void OnAwake()
        {
            NeosVersionHelpers.OverrideHash(Engine);
            Harmony.PatchAll();
        }
    }
}
