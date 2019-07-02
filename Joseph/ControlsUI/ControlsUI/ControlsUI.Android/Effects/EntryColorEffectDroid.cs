using System;
using System.Linq;
using Android.Content.Res;
using ControlsUI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(ControlsUI.Droid.Effects.EntryColorEffectDroid), nameof(EntryColorEffect))]
namespace ControlsUI.Droid.Effects
{
    public class EntryColorEffectDroid : PlatformEffect
    {

        protected override void OnAttached()
        {
            try
            {
                var control = Control;
                if (control == null) return;

                var effect = (EntryColorEffect)Element.Effects.FirstOrDefault(e => e is EntryColorEffect);
                if (effect != null)
                {
                    if (!effect.IsApplyToDroid) return;
                    control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.White);
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
