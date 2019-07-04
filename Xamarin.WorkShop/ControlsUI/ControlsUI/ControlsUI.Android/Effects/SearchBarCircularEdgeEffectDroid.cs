
using ControlsUI.Views;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using System;
using Android.Widget;
using System.Linq;

[assembly: ResolutionGroupName("ControlsUI")]
[assembly: ExportEffect(typeof(ControlsUI.Droid.Effects.SearchBarCircularEdgeEffectDroid), nameof(SearchBarCircularEdgeEffect))]
namespace ControlsUI.Droid.Effects
{
	public class SearchBarCircularEdgeEffectDroid : PlatformEffect
	{
		protected override void OnAttached()
		{
			try
			{
				var control = Control as SearchView;
				if (control == null) return;

				var effect = (SearchBarCircularEdgeEffect)Element.Effects.FirstOrDefault(e => e is SearchBarCircularEdgeEffect);
				if(effect != null)
				{
					if (!effect.IsApplyToDroid) return;
					control.SetBackgroundResource(Resource.Drawable.RoundEdge);

                    int searchPlateId = control.Context.Resources.GetIdentifier("android:id/search_plate", null, null);
                    Android.Views.View searchPlateView = control.FindViewById(searchPlateId);
                    searchPlateView.SetBackgroundColor(Android.Graphics.Color.Transparent);

                    var searchIconId = control.Context.Resources.GetIdentifier("android:id/search_icon", null, null);
                    Android.Views.View searchIconView = control.FindViewById(searchIconId);
                    searchIconView.SetBackgroundColor(Android.Graphics.Color.White);
                }
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