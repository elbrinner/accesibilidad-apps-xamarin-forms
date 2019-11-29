using System;
namespace AccesibilidadDemo.Service
{
    public interface IAccessibility
    {
        void PostVoiceOver(string textToSpeak);

        bool IsVoiceOverRunning();
    }
}
