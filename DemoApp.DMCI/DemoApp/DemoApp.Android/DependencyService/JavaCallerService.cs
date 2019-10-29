using Com.Example.Message;
using DemoApp.DependencyService;
using Plugin.CurrentActivity;
using XF = Xamarin.Forms;

[assembly: XF.Dependency(typeof(DemoApp.Droid.DependencyService.JavaCallerService))]
namespace DemoApp.Droid.DependencyService
{
    public class JavaCallerService : IJavaCaller
    {
        public void CallJavaMessageApi()
        {
            //here to call jar speci MessageView api
            var context = CrossCurrentActivity.Current.Activity;
            ViewMessage viewMessage = new ViewMessage(context);
            viewMessage.MessageView(false);
        }
    }
}