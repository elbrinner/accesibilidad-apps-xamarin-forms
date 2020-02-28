
using AccesibilidadDemo.Service;
using AccesibilidadDemo.UWP.Services;
using Windows.UI.Xaml.Automation.Peers;



using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using System.IO;
using System.Runtime.InteropServices;
using System.ComponentModel;

[assembly: Xamarin.Forms.Dependency(typeof(Accessibility))]
namespace AccesibilidadDemo.UWP.Services
{
    public class Accessibility : IAccessibility
    {
        public bool IsVoiceOverRunning()
        {
            return MainPage.IsNaratorActive;
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
