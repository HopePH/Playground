using Android.Content;
using Android.Media;
using Plugin.CurrentActivity;
using Xamarin.Forms.Platform.Android;
using XF = Xamarin.Forms;

[assembly: XF.ExportRenderer(typeof(DemoApp.CustomControls.RoundedImage),
    typeof(DemoApp.Droid.CustomControls.RoundedImageDroid))]
namespace DemoApp.Droid.CustomControls
{
    public class RoundedImageDroid : ImageRenderer
    {
        public RoundedImageDroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<XF.Image> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var context = CrossCurrentActivity.Current.Activity;
                var roundedImage = new RoundedImageView(context);
                roundedImage.SetImageResource(Resource.Drawable.manokpula);
                SetNativeControl(roundedImage);
            }
        }
    }
}