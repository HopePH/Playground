using System;
using ControlsUI.Views;
using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using XF = Xamarin.Forms;

[assembly: XF.ResolutionGroupName("ControlsUI")]
[assembly: XF.ExportEffect(typeof(ControlsUI.iOS.Effects.EntryEffectiOS), nameof(SearchBarCircularEdgeEffect))]
namespace ControlsUI.iOS.Effects
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
                    using (var searchKey = new NSString("_searchField"))
                    {
                        var textField = (UITextField)control.ValueForKey(searchKey);
                        textField.TextColor = UIColor.White;
                        textField.BackgroundColor = XF.Color.FromHex("#88299b").ToUIColor();
                        textField.BorderStyle = UITextBorderStyle.None;
                        textField.Background = new UIImage();
                    }

                    control.Layer.CornerRadius = 10;
                    control.Layer.BorderWidth = 0;
                    control.Layer.BorderColor = XF.Color.White.ToCGColor();
                    control.TintColor = UIColor.White;

                    //foreach (var subView in control.Subviews)
                    //{
                    //    foreach (var subView1 in subView.Subviews)
                    //    {
                    //        if (subView1.GetType() == typeof(UITextField))
                    //        {
                                
                    //            // subView1.BackgroundColor = XF.Color.Transparent.ToUIColor();
                    //            //subView1.BorderStyle = UITextBorderStyle.None;
                    //            //subView1.Background = new UIImage();
                    //        }
                    //    }
                    //}
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
