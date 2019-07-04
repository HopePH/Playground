using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Input;

namespace Calculator_Prism.ViewModels
{
	public class MainPageViewModel : BindableBase
	{
		public ICommand AddCommand => new DelegateCommand(Add);

		public string Title { get; set; }
		public string FirstNumber { get; set; }
		public string SecondNumber { get; set; }
		public string Total { get; set; }

		public void Add()
		{
			int Sum = int.Parse(FirstNumber) + int.Parse(SecondNumber);
			Total = Sum.ToString();
			RaisePropertyChanged(nameof(Total));
		}
	}
}
