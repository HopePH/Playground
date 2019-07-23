using Com.Example.Message;
using Plugin.CurrentActivity;
using SimpleMessage.Utility;
using Xamarin.Forms;
using System;

[assembly: Dependency(typeof(SimpleMessage.Droid.DependencyService.MessageUtility))]
namespace SimpleMessage.Droid.DependencyService
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
			catch (Exception ex)
			{
			}
		}
	}
}