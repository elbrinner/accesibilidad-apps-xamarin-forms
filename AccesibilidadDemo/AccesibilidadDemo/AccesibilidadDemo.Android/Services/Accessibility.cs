using System;
using System.Collections.Generic;
using AccesibilidadDemo.Droid.Services;
using AccesibilidadDemo.Service;
using Android.AccessibilityServices;
using Android.Content;
using Android.OS;
using Android.Views.Accessibility;
using Android.Widget;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(Accessibility))]
namespace AccesibilidadDemo.Droid.Services
{
    public class Accessibility : IAccessibility
    {
        Context context = Forms.Context;

        public bool IsVoiceOverRunning()
        {


           

            AccessibilityManager am = (AccessibilityManager)Android.App.Application.Context.GetSystemService(Context.AccessibilityService);
            if (am != null && am.IsEnabled)
            {
               var serviceInfoList = am.GetEnabledAccessibilityServiceList(FeedbackFlags.Spoken);
                if (serviceInfoList!=null)
                    return true;
            }
            return false;
        }

        public void PostVoiceOver(string textToSpeak)
        {
            if (IsVoiceOverRunning())
            {
                Toast.MakeText(context, textToSpeak, ToastLength.Short).Show();
            }
         
        }

        
    }
}
