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
    public sealed partial class Page11 : Page
    {
        public Page11()
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

        private void star_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String star = "Moonlight, the stars and the wind,@By placing them in front@And drinking the honey thereof-@A poetic frenzy seizes us;@That atomic thing called Mind @We shall let it roam free.@Should one wonder at the bee that sings@While imbedded in a tasty fruit?@The jewel of stars.@";
            star = star.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), star);
        }

        private void wind_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String wind = "Wind, come softly.@ Don’t break the shutters of the windows.@Don’t scatter the papers. @Don’t throw down the books on the shelf.@There, look what you did — you threw them all down.@You tore the pages of the books.@You brought rain again. @You’re very clever at poking fun at weaklings. @Frail crumbling houses, crumbling doors, crumbling rafters, @crumbling wood, crumbling bodies, crumbling lives,@crumbling hearts —@the wind god winnows and crushes them all. @He won’t do what you tell him.@So, come, let’s build strong homes,@Let’s joint the doors firmly.@Practise to firm the body.@Make the heart steadfast. @Do this, and the wind will be friends with us.@ The wind blows out weak fires.@ He makes strong fires roar and flourish.@His friendship is good.@We praise him every day.@";
            wind = wind.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), wind);
        }

        private void freedom_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String freedom = "When will this thirst for freedom slake?@When will our love of slavery die?@When will our Mother's fetters break?@ When will our tribulations cease?@Wasn't there another Bharat @Reared by our noble Aryan race?@ Lead us, Aryan, to victory!@Is't right we remain slaves?@ Are famine and disease alone our share?@For whom, then, are the laurels and fruits?@Will you abandon us, your suppliants?@ Can the mother cast her child aside?@Brave warrior!Aryan Lord!@Thou destroyer of the demon-race,@ Where is your dharma? Isn't yours the duty@ To revive us, and chase Fear away?";
            freedom = freedom.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), freedom);
        }

        private void order_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String order = "Satan residing little mind@ Listen to my words from today@Don't you go searching alone@ For Im your leader, you better know@Mother Sakthi's feet and@ Righteousness, as what I proclaim to be@Without laziness you shall stand and work@I sermonize, abide and you will live high. ";
            order = order.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), order);
        }

        private void fear_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String fear = "The people of this world, if against they stand,@ There is no fear, there is no fear, nothing like fear.@Although, we are counted cheap and rebuked,@There is no fear , there is no fear , nothing like fear.@There is no fear, there is no fear, nothing like fear.@Loveable possessions if, are lost,@There is no fear , there is no fear , nothing like fear.2.If clothed bosomed damsels, cast their eyes@There is no fear , there is no fear , nothing like fear.@Poison in the mouth, if fed by friends@There is no fear , there is no fear , nothing like fear.@Shielded armies, if to attack approach@There is no fear , there is no fear , nothing like fear.@On the acme of my head, if the sky did crash and plummet down@There is no fear , there is no fear , nothing like fear.";
            fear = fear.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), fear);
        }

        private void spark_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String spark = "A spark of fire I did see@ Which there, in a forest tree hole I'd stowed@ Burned and ashed was the forest@For the flame's intensity, is there something like a spark or a blaze ?@ ";
            spark = spark.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), spark);
        }
        
    }
}
