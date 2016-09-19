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
    public sealed partial class Love_Page : Page
    {
        public Love_Page()
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

        private void promise_Click(object sender, RoutedEventArgs e)
        {
            String promise = "You light up my world,@And make me forget all my fears,@Your laughter brightens up my days,@And chases away all my tears.@You are my every dream come true,@No one else will ever do;@Because only you can make me feel,@The way I do.@My heart beats at least a million times,@Whenever you cross my mind.@You’ve got a special way with me,@You make me believe,@In this love that we’ve found,@And I promise I’ll never let you down.@";
            promise = promise.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), promise);
        }

        private void heart_Click(object sender, RoutedEventArgs e)
        {
            String heart = "A million stars up in the sky@one shines brighter I can't deny@A love so precious a love so true@a love that comes from me to you@The angels sing when you are near@within your arms I have nothing to fearYou always know just what to say@just talking to you makes my day@I love you honey with all of my heart@together forever and never to part.";
            heart = heart.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), heart);
        }

        private void you_Click(object sender, RoutedEventArgs e)
        {
            String you = "You are the smile within my heart@The life within my soul@You are the joy within my laughter@The half that makes me whole@You are the twinkle in my eye@sThe hope in all my dreams@You are the inspiration in all I do@You are all I really need@You are my tomorrow@The love that gives me faith@You are my forever@And this will never change@";
            you = you.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), you);
        }

        private void tome_Click(object sender, RoutedEventArgs e)
        {
            String tome = "In all our time together@You’ve come to mean so much to me@You are my best friend@My life and all my dreams@You give me hope when I’m all out@You are my pick-me - up@When I’m feeling down@You make me feel good about myself@There will never be anyone else@For the rest of time@To love me like you do@And for me to love too@The way I love you@You mean the world to me@You are my soul@my spirit@My everything@";
            tome = tome.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), tome);
        }

        private void last_Click(object sender, RoutedEventArgs e)
        {
            String last = "I love that each day@I wake up to a world that has you in it@And that I’ve been blessed@With a life that took a path@That lead me straight to you@I’ve never been as happy@Or at peace as I am@since you’ve become a part of my life@There was a time@When I thought I’d never find@This calm, peaceful feeling@That true love has given me@After all the bridges I’ve crossed@And all the paths I’ve taken@After all the journey’s@And all the let downs@At last@I took the right path,@I crossed the right bridge@And my journey has ended@At Last@I found my heart@My best friend, my one true love@At last, I found you";
            last = last.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), last);
        }
    }
}
