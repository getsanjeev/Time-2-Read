using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class daru : Page
    {
        public daru()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void war_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string war = "we who are at war with ourselves,@our dreams moving along the barbed@contour of our angsts - the hit - or - miss@meteorites that turn space@into a shooting gallery,@flamingoes that may never fly back@to the salt puddles of Kutch,@the chinese spiriting away the brahmaputra@in a gargantuan theft,@and india turning into a bombay local,@asphyxiating in the smell of two billion armpits@isn't all this enough @to give us a collective cerebral bleed?@not forgetting our planet@which has a hot plate under its arse -@and my dream which saw@an abu dhabi dhow squatting on an iceberg@sailing down to cochin--@haven't we enough on our plate@without having to think of war@and blood-stained jehad ?";
            war = war.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), war);
        }

        private void hawk_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string hawk = "The tamed one is worse, for he is touched by man.@Hawking is turned to a ritual, the predator’s@passion honed to an art;@They can’t kill him in one fell swoop.@But each time the talons cart away@a patch of ripped fur.@He diminishes one talon-morsel at a time.@But I am learning how to spot the ones@crying for the right to dream, the right to flesh,@trained for havoc,@my eyes focused on them@like the sights of a gun.@During the big drought which is surely going to come@the doves will look up for clouds, and it will rain hawks@";
            hawk = hawk.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), hawk);
        }

    }
}
