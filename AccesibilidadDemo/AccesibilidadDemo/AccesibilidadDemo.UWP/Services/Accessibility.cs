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
namespace AccesibilidadDemo.UWP.Services
{
    public class Accessibility : IAccessibility
    {
        Context context = Forms.Context;

        public bool IsVoiceOverRunning()
        {
           
            return AutomationPeer.ListenerExists(AutomationEvents.AutomationFocusChanged); ;
        }

        public void PostVoiceOver(string textToSpeak)
        {
            if (IsVoiceOverRunning())
            {
                var xmlToastTemplate = "<toast launch=\"app-defined-string\">" +
                          "<visual>" +
                            "<binding template =\"ToastGeneric\">" +
                             
                              "<text>" +
                               textToSpeak +
                              "</text>" +
                            "</binding>" +
                          "</visual>" +
                        "</toast>";

                // load the template as XML document
                var xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlToastTemplate);

                // create the toast notification and show to user
                var toastNotification = new ToastNotification(xmlDocument);
                var notification = ToastNotificationManager.CreateToastNotifier();
                notification.Show(toastNotification);
            }
         
        }

        
    }
}
