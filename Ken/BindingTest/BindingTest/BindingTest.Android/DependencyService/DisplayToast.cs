
using BindingTest.Utility;
using Xamarin.Forms;
using Plugin.CurrentActivity;
using System;

using Com.Example.Message;

[assembly: Dependency(typeof(BindingTest.Droid.DependencyService.DisplayToast))]
namespace BindingTest.Droid.DependencyService
{
    public class DisplayToast : IDisplayToast
    {
        private bool _isToast = true;
        public void DisplayToastMessage()
        {
            try
            {
                var activity = CrossCurrentActivity.Current.Activity;
                ViewMessage viewMessage = new ViewMessage(activity);
                viewMessage.MessageView(_isToast);
            }
            catch (Exception ex)
            {

            }
        }
    }
}