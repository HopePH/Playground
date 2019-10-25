using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace EffectsBehaviorsDemo.Behaviors
{
    public class EmailEntryBehavior : Behavior<Entry>
    {
        private const string EMAILREGEX = @"^([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,5})$";

        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += Bindable_TextChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= Bindable_TextChanged;
            base.OnDetachingFrom(bindable);
        }
        private void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = sender as Entry;

            if (Regex.IsMatch(e.NewTextValue, EMAILREGEX))
                entry.TextColor = Color.Default;
            else
                entry.TextColor = Color.Red;
        }
    }
}
