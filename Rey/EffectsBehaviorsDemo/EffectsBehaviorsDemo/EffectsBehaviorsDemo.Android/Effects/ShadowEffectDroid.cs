using EffectsBehaviorsDemo.Droid.Effects;
using EffectsBehaviorsDemo.Effects;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(ShadowEffectDroid), nameof(ShadowEffect))]
namespace EffectsBehaviorsDemo.Droid.Effects
{
    public class ShadowEffectDroid : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var control = Control as Android.Widget.TextView;
                var effect = Element.Effects.FirstOrDefault(e => e is ShadowEffect) as ShadowEffect;
                if (effect != null)
                {
                    float radius = effect.Radius;
                    float distanceX = effect.DistanceX;
                    float distanceY = effect.DistanceY;
                    Android.Graphics.Color color = effect.Color.ToAndroid();
                    control.SetShadowLayer(radius, distanceX, distanceY, color);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Cannot set property on attached control. Error {ex.Message}");
            }
        }

        protected override void OnDetached() { }
    }
}