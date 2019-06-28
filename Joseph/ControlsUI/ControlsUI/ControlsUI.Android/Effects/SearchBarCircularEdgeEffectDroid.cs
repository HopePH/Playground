using Android.Views;
using ControlsUI.Views;
using System;
using Xamarin.Forms.Platform.Android;
using XF = Xamarin.Forms;

[assembly: XF.ResolutionGroupName("ControlsUI")]
[assembly: XF.ExportEffect(typeof(ControlsUI.Droid.Effects.SearchBarCircularEdgeEffectDroid), nameof(SearchBarCircularEdgeEffect))]
namespace ControlsUI.Droid.Effects
{
	public class SearchBarCircularEdgeEffectDroid : PlatformEffect
	{
		protected override void OnAttached()
		{
			try
			{
				var myControl = Control;
				myControl.SetBackgroundColor(XF.Color.Red.ToAndroid());
				string temp = "";
			}
			catch (Exception ex)
			{
				Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
			}
		}

		protected override void OnDetached()
		{
			
		}
	}
}