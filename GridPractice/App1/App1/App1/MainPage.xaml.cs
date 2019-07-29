using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            phoneNumbers.ItemsSource = new List<Contacts>
            {
                new Contacts { Name = "Juan Dela Cruz", Contact = "(+63) 123456789", Email = "juandelacruz@gmail.com ",Image = "img1"},
                new Contacts { Name = "Mc Kenley Lindong", Contact ="(+63) 987654321", Email = "mckenleylindong@gmail.com" , Image = "img2"},
                new Contacts { Name = "Juana Dela Cruz", Contact = "(+63) 090909090", Email = "juana@gmail.com", Image = "img3" }
            };

       
        }

        
    }
}
