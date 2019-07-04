using ControlsUI.Views;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using System;
using Android.Widget;
using System.Linq;
using Plugin.CurrentActivity;

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

                    //search plate
                    int searchPlateId = control.Context.Resources.GetIdentifier("android:id/search_plate", null, null);
                    var searchPlateView = control.FindViewById(searchPlateId);

                    if (searchPlateView != null)
                        searchPlateView.SetBackgroundColor(Android.Graphics.Color.Transparent);

                    //search icon color
                    var searchIconId = control.Context.Resources.GetIdentifier("android:id/search_mag_icon", null, null);
                    var searchIconView = (ImageView) control.FindViewById(searchIconId);
                    var context = CrossCurrentActivity.Current.Activity;

                    if (searchIconView != null)
                    {
                        var drawable = context.GetDrawable(Resource.Drawable.searchw);
                        searchIconView.SetImageDrawable(drawable);
                    }

                    //hint color
                    var srcTextId = control.Context.Resources.GetIdentifier("android:id/search_src_text", null, null);
                    var searchSourceText = (EditText) control.FindViewById(srcTextId);

                    if (searchSourceText != null)
                    {
                        searchSourceText.SetHintTextColor(Color.White.ToAndroid());
                        searchSourceText.SetTextColor(Color.White.ToAndroid());
                    }
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