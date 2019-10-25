using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace EffectsBehaviorsDemo.Behaviors
{
    public class PasswordEntryBehavior : Behavior<Entry>
    {
        private const string PASSWORDREGEX = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
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

            if (Regex.IsMatch(e.NewTextValue, PASSWORDREGEX))
            {
                entry.TextColor = Color.Default;
            }
            else
            {
                entry.TextColor = Color.Red;
            }
        }
    }
}
