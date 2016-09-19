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
    public sealed partial class Page15 : Page
    {
        public Page15()
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

        private void hymns_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String hymn = "Don't curse the darkness@since you are told not to,@... but don't be in a hurry@to light a candle either.@The darkness has its secrets@which light does not know.@It's a kind of perfection,@while every light@distorts the truth.@Present at the creation@of the universe,@I would perhaps have proceeded@differently.@But if the destruction@is in our lifetime,@the mushroom cloud@is as good a way@as any I can think of,@and more aesthetic.@In the presence of death,@remember, do not console yourself;@there's only death here,@only life.@You are master@neither of death nor of life.@Belief will not save you,@nor unbelief.@All you have@is the sense of reality,@unfathomable@as it yields its secrets@slowly one@by one.";
            hymn = hymn.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), hymn);
        }

        private void night_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String night = "I remember the night my mother@was stung by a scorpion.Ten hours@of steady rain had driven him@... to crawl beneath a sack of rice.@Parting with his poison -flash@of diabolic tail in the dark room -@he risked the rain again.@The peasants came like swarms of flies@and buzzed the name of God a hundred times@to paralyse the Evil One.@With candles and with lanterns@throwing giant scorpion shadows@on the mud-baked walls@they searched for him: he was not found.@They clicked their tongues.@With every movement that the scorpion made his poison moved in Mother's blood, they said.@May he sit still, they said@May the sins of your previous birth@be burned away tonight, they said.@May your suffering decrease@the misfortunes of your next birth, they said.@May the sum of all evil@balanced in this unreal world@against the sum of good@become diminished by your pain.@May the poison purify your flesh@of desire, and your spirit of ambition,@they said, and they sat around@on the floor with my mother in the centre,@the peace of understanding on each face.@More candles, more lanterns, more neighbours,@more insects, and the endless rain.@My mother twisted through and through,@groaning on a mat.@My father, sceptic, rationalist,@trying every curse and blessing,@powder, mixture, herb and hybrid.@He even poured a little paraffin@upon the bitten toe and put a match to it.@I watched the flame feeding on my mother.@I watched the holy man perform his rites to tame the poison with an incantation.@After twenty hours@it lost its sting.@My mother only said@Thank God the scorpion picked on me@And spared my children.";
            night = night.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), night);
        }

        private void candle_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String candle = "What's the second candle for, I asked@my wife that Friday night.Wait, she said,@... till they are lit and the prayer is over.@Then she turned to me with a cunning smile:@The first candle is for God's daily blessings,@just the usual things, you know,@Life itself, food and drink, love, children,@friends, relatives, books, flowers,@freedom from misfortunes,@all the plain prose of daily breath@which, for me, is poetry.She paused,@wanting me to repeat the question.@What's the second candle for? I didn't repeat it, patiently silent...@Then she added quickly before turning away,@The second candle is for a miracle I need@a special favour, a certain turn of events@what work alone will never bring,@a gift we do not quite deserve@but still may get by asking for it.@Call it grace, if you like, a windfall,@bonus, dearness allowance,@more than a promotion, some kind of new dimension, revelation.@Well, that's what the second candle's for.@Now do you understand.@She didn't wait for my answer. I looked at the two candles@shining there@and wonderful at the faith@that deals so simply with it's God.@";
            candle = candle.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), candle);
        }

        private void trans_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String trans = "Light is the opposite@of heavy and of darkness.@I have always@consciously@loved the word@and all it stood for-@yet more than half my hours@are heavy and dark.@Compared to my mind@rocks are reasonable,@clouds are clear.@It makes me mad@but that is how it is.@How many times@have I felt free ?@How many times@Spontaneous ?@It's fantastic@what a slave@a man can be@who has nobody@to oppress him@except himself.@And don't tell me@there's any happiness@in being compulsive@or mindless.@The most painful@confrontation@makes me happier,@but I still rush off@in every direction at once@and fall for every bait.@It is a falling -@a most terrible thing.@And what one learns@is not all that important@because one has learnt it@already, over and over again.@Who wants experience@at the cost of achievement ?@All I want now@is the recognition@of dilemma@and the quickest means@of resolving it@within my limits.";
            trans = trans.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), trans);
        }

        private void pred_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String pred = "I am not superstitious.@The Zodiac predicts a newcreative phase of seven years@for Sagittarians.I remind myself@that to be the healer,@not the sick@or the indifferent one@was always my ambition;@and to rage against the barren@not only in friend or stranger@but perfectly familiar@in  my own signature.@This is the place@where I was born.I@know it@well.It is home,@which I recognise at last@as a kind of hell@to be made tolerable.@Let the fevers come,@the patterns break@and form again@for me and for the place.@I say to it and to myself:@not to be dead or dying@is a cause for celebration.@Watching spiders climb@the commonplace, ants@co - operate, lakes@reflect the hills of some@remembered holiday,@ships and swans engender@legends, morals, music,@I seek on firmer ground@to improvise my later fiction,@the fallen world@a faithful friend.@I also learn@to make light of the process,@to be the bird in balance@on the turbulent air@and yet as present here@as any solid human body,@heavy, slow and wishbone@breakable, straining to stay young.@";
            pred = pred.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), trans);            
        }
    }
}
