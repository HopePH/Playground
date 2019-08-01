using System;

namespace SpecFlowPractice
{
    class Calculator
    {
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }
        public int Result { get; set; }
        public string Message { get; set; }

        public bool Add()
        {
            var fNo = FirstNumber.Replace("\"", "");
            var sNo = SecondNumber.Replace("\"", "");
            bool hasError = true;

            try
            {
                Result = int.Parse(fNo) + int.Parse(sNo);
                hasError = false;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Input string was not in a correct format"))
                {
                    hasError = true;
                    Message = "Please enter a number!";
                }
                else
                    throw;
            }

            return hasError;
        }
    }
}
