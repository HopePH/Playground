using BasicMVVM.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicMVVM.FakeData
{
    public class FakeList
    {
        private static List<Customer> CustomersField;
        public static IEnumerable<Customer> FakeCustomerList => CustomersField;
        static FakeList() => Init();
        public static void Init()
        {
            CustomersField = new List<Customer>
            {
                new Customer
                {
                    FirstName = "Alfie",
                    LastName = "Salaño"
                },

                new Customer
                {
                    FirstName = "Chito",
                    LastName = "Salaño"
                }

            };

        }
    }
}
