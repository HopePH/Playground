using BasicMVVM.FakeData;
using BasicMVVM.Model;
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace BasicMVVM
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand MathCommand => new Command(GenerateRandomNo);
        public string Result { get; set; } = "";
        public Customer CustomerInfo { get; set; }

        public MainPageViewModel()
        {
            //GetCustumerDetails();
        }

        private void GenerateRandomNo()
        {
            int resultDouble = RandomNumber(1, 1000000);
            Result = $"My generated no: {resultDouble.ToString()}";
            NotifyPropertyChanged(nameof(Result));
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void GetCustumerDetails()
        {
            CustomerInfo = FakeList.FakeCustomerList.FirstOrDefault(x => x.FirstName == "Alfie");
        }
    }
}
