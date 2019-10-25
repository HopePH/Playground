using Xamarin.Forms;

namespace PokeDex.Effects
{
    public class ButtonGDEffect : RoutingEffect
    {
        public double CornerRadius { get; set; }

        public ButtonGDEffect() : base("PokeDex.ButtonGDEffect")
        {
        }
    }
}
