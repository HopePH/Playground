using System;
using System.Linq;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Widget;
using PE = PokeDex.Effects;
using Xamarin.Forms.Platform.Android;
using XF = Xamarin.Forms;

[assembly: XF.ResolutionGroupName("PokeDex")]
[assembly: XF.ExportEffect(typeof(PokeDex.Droid.Effects.ButtonGDEffect), nameof(PE.ButtonGDEffect))]
namespace PokeDex.Droid.Effects
{
    public class ButtonGDEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var effects = (PE.ButtonGDEffect)Element.Effects.FirstOrDefault(e => e is PE.ButtonGDEffect);
                var control = Control as Button;
                if (control == null) return;
                int[] colors = { XF.Color.FromHex("#DA596A").ToAndroid(), XF.Color.FromHex("#FF8A97").ToAndroid() };
                GradientDrawable gd = new GradientDrawable(GradientDrawable.Orientation.LeftRight, colors);
                gd.SetCornerRadius(10 * (float)effects.CornerRadius);
                control.SetBackground(gd);
                control.SetAllCaps(false);

                var font = Typeface.CreateFromAsset(Android.App.Application.Context.ApplicationContext.Assets, "MuseoSansCyrl_0.otf");
                control.Typeface = font;
            }
            catch (Exception ex)
            {
                //do nothing
            }
        }

        protected override void OnDetached() { }
    }
}