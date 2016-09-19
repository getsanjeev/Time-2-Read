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
    public sealed partial class Page14 : Page
    {
        public Page14()
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

        private void rain_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String rain = "Sometimes a rain comes@slowly across the sky, that turns@upon its grey cloud, breaking away into light@before it reaches its objective.@The rain I have known and traded all this life@is thrown like kelp on the beach.@Like some shape of conscience I cannot look at,@a malignant purpose in a nun's eye.@Who was the last man on earth,@to whom the cold cloud brought the blood to his face?@Numbly I climb to the mountain-tops of ours@where my own soul quivers on the edge of answers.@Which still, stale air sits on an angel's wings?@What holds my rain so it's hard to overcome?";
            rain = rain.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), rain);
        }

        private void sum_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String sum = "Not yet.@Under the mango tree@The cold ash@of a deserted fire.@Who needs the future?@A ten-year - old girl@combs her mother's hair,@where crows of rivalries@are quietly nesting.@The home@will never be hers.@In a corner of her mind@a living green mango@drops softly to earth.@";
            sum = sum.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), sum);
        }

        private void hun_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String hun = "It was hard to believe the flesh was heavy on my back.@The fisherman said: Will you have her, carelessly,@trailing his nets and his nerves, as though his words@sanctified the purpose with which he faced himself.@I saw his white bone thrash his eyes.@I followed him across the sprawling sands,@my mind thumping in the flesh's sling.@Hope lay perhaps in burning the house I lived in.@Silence gripped my sleeves; his body clawed at the froth@his old nets had only dragged up from the seas.@In the flickering dark his lean-to opened like a wound.@The wind was I, and the days and nights before.@Palm fronds scratched my skin.Inside the shack@an oil lamp splayed the hours bunched to those walls.@Over and over the sticky soot crossed the space of my mind.@I heard him say: My daughter, she's just turned fifteen ...@Feel her. I'll be back soon, your bus leaves at nine.@The sky fell on me, and a father's exhausted wile.@Long and lean, her years were cold as rubber.@She opened her wormy legs wide.I felt the hunger there,@the other one, the fish slithering, turning inside.";
                hun = hun.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), sum);
        }

        private void myth_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String myth = "Years drift sluggishly through the air:@a chanting, the long years, an incense.@Face upon face returns to the barbed horizons@of the foggy temple; here lies@a crumpled leaf, a filthy scarlet flower@out of placeless pasts, on the motionless stairs.@Old brassy bells@moulded by memories, dark, unfulfilled,@to make the year come back again --@a recurring prayer.@The stairs seem endless, lifelong,@and those peaks too, Annapurna, Dhaulagiri;@uncertain, impressive as gods.@I dare not go@into the dark, dank sanctum@where the myth shifts@swiftly from hand to hand, eye to eye.@The dried, sacrificed flowers smile at me.@I have become;@a diamond in my eye@Vague grieving years pit against@the distant peaks@like a dying butterfly@as a bearded, saffron - robed man@asks me, firmly:@Are you a Hindu?";
                myth = myth.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), sum);
        }

        private void temple_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String temple = "Children, brown as earth, continue to laugh away@at cripples and mating mongrels.@Nobody ever bothers about them.@The temple points to unending rhythm.@On the dusty street the colour of shorn scalp@there are things moving all the time@and yet nothing seems to go away from sight.@Injuries drowsy with the heat.@And that sky there,@claimed by inviolable authority,hanging on to its crutches of silence.";
            temple = temple.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), sum);
        }

        private void taste_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String taste = "At Puri, the crows.@The one wide street@lolls out like a giant tongue.@Five faceless lepers move aside@as a priest passes by.@And at the streets end@the crowds thronging the temple door:@a huge holy flower@swaying in the wind of greater reasons.";
            taste = taste.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), taste);
        }

        private void missing_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String missing = "In the darkened room@a woman@cannot find her reflection in the mirror@waiting as usual@at the edge of sleep@In her hands she holds@the oil lamp@whose drunken yellow flames@know where her lonely body hides";
            missing = missing.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), missing);
        }
    }
}
