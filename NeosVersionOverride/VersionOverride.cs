using BaseX;
using FrooxEngine;
using FrooxEngine.UIX;

namespace NeosVersionOverride
{
    [Category("Add-Ons/")]
    public class VersionOverride : Component, ICustomInspector
    {

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
        }
    }
}
