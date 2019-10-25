using EffectsBehaviorsDemo.Droid.Effects;
using EffectsBehaviorsDemo.Effects;
using System;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("EffectsBehavioursDemo")]
[assembly: ExportEffect(typeof(FocusEffectDroid), nameof(FocusEffect))]
namespace EffectsBehaviorsDemo.Droid.Effects
{
    public class FocusEffectDroid : PlatformEffect
    {
        Android.Graphics.Color originalBackgrounColor = new Android.Graphics.Color(0, 0, 0, 0);
        Android.Graphics.Color backgroundColor;
        protected override void OnAttached()
        {
            try
            {
                var effect = Element.Effects.FirstOrDefault(e => e is FocusEffect) as FocusEffect;

                if (effect != null)
                {
                    backgroundColor = effect.FocusColor.ToAndroid();
                }

                Control.SetBackgroundColor(originalBackgrounColor);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Cannot set property on attached control. Error {ex.Message}");
            }
        }

        protected override void OnDetached() { }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            try
            {
                if (args.PropertyName == "IsFocused")
                {
                    if (((Android.Graphics.Drawables.ColorDrawable)Control.Background).Color == backgroundColor)
                    {
                        Control.SetBackgroundColor(originalBackgrounColor);
                    }
                    else
                    {
                        Control.SetBackgroundColor(backgroundColor);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Cannot set property on attached control. Error {ex.Message}");
            }
        }
    }
}