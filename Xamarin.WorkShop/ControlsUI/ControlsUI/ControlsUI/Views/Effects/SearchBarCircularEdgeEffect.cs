
using Xamarin.Forms;

namespace ControlsUI.Views
{
	public class SearchBarCircularEdgeEffect : RoutingEffect
	{
		public SearchBarCircularEdgeEffect() : base("ControlsUI.SearchBarCircularEdgeEffect") { }

		public bool IsApplyToDroid { get; set; } = true;
	}
}
