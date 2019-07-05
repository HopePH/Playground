using System;
using ControlsUI.Views;
using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using XF = Xamarin.Forms;

[assembly: XF.ExportEffect(typeof(ControlsUI.iOS.Effects.EntryColorEffectiOS), nameof(EntryColorEffect))]
namespace ControlsUI.iOS.Effects
{
    public class EntryColorEffectiOS : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var control = Control;

                if (control != null)
                {
                    control.BackgroundColor = XF.Color.Transparent.ToUIColor();
                    control.Layer.BorderColor = XF.Color.White.ToCGColor();
                    control.Layer.BorderWidth = 0;
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
