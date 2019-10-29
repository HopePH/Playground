
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using XF = Xamarin.Forms;

[assembly: XF.ResolutionGroupName("DemoApp")]
[assembly: XF.ExportEffect(typeof(DemoApp.Droid.Effects.GDButtonDroid),
    nameof(DemoApp.Effects.GDButton))]
namespace DemoApp.Droid.Effects
{
    public class GDButtonDroid : PlatformEffect
    {
        protected override void OnAttached()
        {
            //code java like
            var control = Control as Button;
            if (control == null) return;
            int[] colors = { Color.ParseColor("#DA596A"), Color.ParseColor("#FF8A97") };

            //create a new gradient color
            GradientDrawable gd = new GradientDrawable(
              GradientDrawable.Orientation.LeftRight, colors);

            gd.SetCornerRadius(10f);
            control.SetBackground(gd);
        }

        protected override void OnDetached()
        {
            
        }
    }
}