using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;

namespace Calculator_Prism
{
    public interface ICalculatorCommand
	{
		AdditionCommand AddCommand { get; }
	}

	public class CalculatorCommand : ICalculatorCommand
	{
		AdditionCommand _additionCommand = new AdditionCommand();

		public AdditionCommand AddCommand
		{
			get { return _additionCommand; }
		}
	}
}
