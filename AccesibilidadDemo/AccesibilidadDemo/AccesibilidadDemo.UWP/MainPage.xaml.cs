using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace AccesibilidadDemo.UWP
{
    public sealed partial class MainPage
    {
        public static bool IsNaratorActive = false;
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new AccesibilidadDemo.App());
        }
        private bool isAutomationPeerCreated = false;

        private bool IsAutomationPeerAttached => this.isAutomationPeerCreated || AutomationPeer.ListenerExists(AutomationEvents.PropertyChanged);

        //triggered everytime you run narrator or any other screen reading software that is based on accessing automation properties
        protected override AutomationPeer OnCreateAutomationPeer()
        {
            if (!this.IsAutomationPeerAttached)
            {
                this.isAutomationPeerCreated = true;
                this.OUR_LOGIC_BASED_ON_ATTACHED_NARRATOR();
            }
            return null;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            this.isAutomationPeerCreated = false;
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (IsAutomationPeerAttached)
            {
                this.OUR_LOGIC_BASED_ON_ATTACHED_NARRATOR();
            }
        }

        private void OUR_LOGIC_BASED_ON_ATTACHED_NARRATOR()
        {
            IsNaratorActive = true;
        }
    }
}
