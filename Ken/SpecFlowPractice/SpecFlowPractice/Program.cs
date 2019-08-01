using System;

namespace SpecFlowPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculator calculator = new Calculator();            
            bool continueLoop = true;

            do
            {
                Console.WriteLine("Enter first number:");
                calculator.FirstNumber = Console.ReadLine();

                Console.WriteLine("Enter second number:");
                calculator.SecondNumber = Console.ReadLine();
                continueLoop = calculator.Add();

                if (continueLoop)
                    Console.WriteLine(calculator.Message);
            }
            while (continueLoop);

            Console.WriteLine("The answer is {0}", calculator.Result.ToString());
        }
    }


}