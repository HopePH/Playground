using Com.Example.Message;
using Plugin.CurrentActivity;
using System;
using Xamarin.Forms;
using XamarinBindings.Utility;

[assembly: Dependency(typeof(XamarinBindings.Droid.DependencyService.MessageUtility))]
namespace XamarinBindings.Droid.DependencyService
{
    public class MessageUtility : IShowUtility
    {
        private bool _isToast = true;
        public void ShowMessage()
        {
            try
            {
                var activity = CrossCurrentActivity.Current.Activity;
                ViewMessage viewMessage = new ViewMessage(activity);
                viewMessage.MessageView(_isToast);
            }
            catch(Exception ex)
            {
            }
        }
    }
}