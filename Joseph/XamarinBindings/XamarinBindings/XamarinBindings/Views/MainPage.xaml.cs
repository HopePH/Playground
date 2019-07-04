using System;
using Xamarin.Forms;
using XamarinBindings.Utility;
using Utility;

namespace XamarinBindings
{
    public partial class MainPage : ContentPage
	{
        public object CrossCurrentActivity { get; private set; }

        public MainPage()
		{
			InitializeComponent();
		}

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            var dependency = DependencyService.Get<ICalculatorUtility>();
            var resultInt = dependency.Addition(int.Parse(num1.Text), int.Parse(num2.Text));
            result.Text = resultInt.ToString();
        }

        private void BtnSub_Clicked(object sender, EventArgs e)
        {
            var dependency = DependencyService.Get<ICalculatorUtility>();
            var resultInt = dependency.Subtraction(int.Parse(num1.Text), int.Parse(num2.Text));
            result.Text = resultInt.ToString();
        }

        private void BtnMul_Clicked(object sender, EventArgs e)
        {
            var dependency = DependencyService.Get<ICalculatorUtility>();
            var resultInt = dependency.Multiplication(int.Parse(num1.Text), int.Parse(num2.Text));
            result.Text = resultInt.ToString();
        }

        private void BtnDiv_Clicked(object sender, EventArgs e)
        {
            var dependency = DependencyService.Get<ICalculatorUtility>();
            var resultInt = dependency.Division(int.Parse(num1.Text), int.Parse(num2.Text));
            result.Text = resultInt.ToString();
        }

        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            num1.Text = string.Empty;
            num2.Text = string.Empty;
            result.Text = string.Empty;
        }

        protected override void OnAppearing()
        {
            BtnClick.Clicked += BtnClick_Clicked;
        }

        private void BtnClick_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IShowUtility>().ShowMessage();
        }
    }

    public class EnrtyLenghtValidationBehaviors : Behavior<Entry>
    {
        public int MaxLenght { get; set; }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += OnEntryTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= OnEntryTextChanged;
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = (Entry)sender;
            if(entry.Text.Length > this.MaxLenght)
            {
                string entryText = entry.Text;
                entryText = entryText.Remove(entryText.Length - 1);
                entry.Text = entryText;
            }
        }
    }
}
