using System;
using Foundation;
using iOSDesign.Views;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("iOSDesign")]
[assembly: ExportEffect(typeof(iOSDesign.iOS.Effects.SearchBarEffectiOS), nameof(SearchBarEffect))]
namespace iOSDesign.iOS.Effects
{
    public class SearchBarEffectiOS : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var control = Control;

                if (control != null)
                {
                    using (var searchKey = new NSString("_searchField"))
                    {
                        var textField = (UITextField)control.ValueForKey(searchKey);
                        textField.TextColor = UIColor.Blue;
                        textField.BackgroundColor = Color.FromHex("#ffffff").ToUIColor();
                        textField.BorderStyle = UITextBorderStyle.None;
                        textField.Background = new UIImage();
                    }

                    control.Layer.CornerRadius = 25;
                    control.Layer.BorderWidth = 2;
                    control.Layer.BorderColor = Color.Red.ToCGColor();
                    control.TintColor = UIColor.Yellow;
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
