using Android.Content;
using Plugin.CurrentActivity;
using PokeDex.RenderedControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RoundedImage), typeof(PokeDex.Droid.Renderers.RoundedImageRenderer))]
namespace PokeDex.Droid.Renderers
{
    public class RoundedImageRenderer : ImageRenderer
    {
        public RoundedImageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
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