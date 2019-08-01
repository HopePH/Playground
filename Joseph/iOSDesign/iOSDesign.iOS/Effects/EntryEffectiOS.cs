using System;
using iOSDesign.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(iOSDesign.iOS.Effects.EntryEffectiOS), nameof(EntryEffect))]
namespace iOSDesign.iOS.Effects
{
    public class EntryEffectiOS : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var control = Control;

                if (control != null)
                {
                    control.BackgroundColor = Color.Blue.ToUIColor();
                    control.Layer.BorderColor = Color.Yellow.ToCGColor();
                    control.Layer.BorderWidth = 2;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something wrong. Error: ", ex.Message);
            }
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}
