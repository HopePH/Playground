
using Xamarin.Forms;

namespace ControlsUI.Views
{
    public class EntryColorEffect : RoutingEffect
    {
        public EntryColorEffect() : base("ControlsUI.EntryColorEffect")
        {
        }

        public bool IsApplyToDroid { get; set; } = true;
    }
}
