using Com.Example.Arithmetic;
using System;
using Utility;
using Xamarin.Forms;


[assembly: Dependency(typeof(XamarinBindings.Droid.DependencyService.CalculatorUtility))]
namespace XamarinBindings.Droid.DependencyService
{
    public class CalculatorUtility : ICalculatorUtility
    {
        private Arithmetic javaArithmetic = new Arithmetic();

        public int Addition(int n1, int n2)
        {
            javaArithmetic.Number1 = n1;
            javaArithmetic.Number2 = n2;
            return javaArithmetic.Add();
        }

        private Subtract javaSubtract = new Subtract();

        public int Subtraction(int n1, int n2)
        {
            javaSubtract.Number1 = n1;
            javaSubtract.Number2 = n2;
            return javaSubtract.InvokeSubtract();
        }

        private Multiply javaMultiply = new Multiply();

        public int Multiplication(int n1, int n2)
        {
            javaMultiply.Number1 = n1;
            javaMultiply.Number2 = n2;
            return javaMultiply.InvokeMultiply();
        }

        private Divide javaDivide = new Divide();

        public int Division(int n1, int n2)
        {
            javaDivide.Number1 = n1;
            javaDivide.Number2 = n2;
            return javaDivide.InvokeDivide();
        }

    }
}