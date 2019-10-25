using Xamarin.Forms;

namespace EffectsBehaviorsDemo.Effects
{
    public class FocusEffect : RoutingEffect
    {
        public Color FocusColor { get; set; } = Color.Transparent;
        public FocusEffect() : base("EffectsBehavioursDemo.FocusEffect") { }
    }
}
