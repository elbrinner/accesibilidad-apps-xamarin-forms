using System;
using System.Runtime.InteropServices;
using AccesibilidadDemo.iOS.Services;
using AccesibilidadDemo.Service;
using Foundation;
using ObjCRuntime;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(Accessibility))]
namespace AccesibilidadDemo.iOS.Services
{
    public class Accessibility : IAccessibility
    {
        [DllImport(Constants.UIKitLibrary, EntryPoint = "UIAccessibilityPostNotification")]
        public extern static void PostNotification(uint notification, IntPtr id);

        public void PostVoiceOver(string textToSpeak)
        {
            PostNotification(1008, new NSString(textToSpeak).Handle);
        }

        public bool IsVoiceOverRunning()
        {
            return UIAccessibility.IsVoiceOverRunning;
        }
    }
}
