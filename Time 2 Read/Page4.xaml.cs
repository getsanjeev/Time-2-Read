using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Time_2_Read
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page4 : Page
    {
        int x1, x2;
        public Page4()
        {
            this.InitializeComponent();

            HardwareButtons.BackPressed += HardwareButtons_BackPressed;

            this.NavigationCacheMode = NavigationCacheMode.Required;
            ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateY;
            ManipulationStarted += (s, e) => x1 = (int)e.Position.X;
            ManipulationCompleted += (s, e) =>
            {
                x2 = (int)e.Position.X;
                if (x1 > x2)
                {
                    Frame.Navigate(typeof(Page5));
                }
               // Frame.BackStack.RemoveAt(Frame.BackStackDepth - 1);
            };
        }
        void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                e.Handled = true;
                Frame.GoBack();
            }
        }

        private void tagore_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page8));
        }

        private void das_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page10));
        }

        private void bhar_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page11));
        }

        private void ghosh_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page13));
        }

        private void naidu_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }
       

    }
}
