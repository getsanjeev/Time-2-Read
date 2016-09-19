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
    public sealed partial class Page10 : Page
    {
        public Page10()
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

        private void blood_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string blood = "When we were children@My brother and I@And always playing on the sands@Drawing birds and animals@Our great-grandmother said one day, @You see this house of ours@Now three hundred years old,@It’s falling to little bits@Before our very eyes@The walls are cracked and torn@And moistened by the rains,@The tiles have fallen here and there@The windows whine and groan@And every night@The rats come out of the holes@And scamper past our doors. @The snake-shrine is dark with weeds@And all the snake-gods in the shrine@Have lichen on their hoods.@O it hurts me she cried,@Wiping a reddened eye@For I love this house, it hurts me much@To watch it die.@When I grow old, I said, And very very richI shall rebuild the fallen wallsAnd make new this ancient house. My great-grandmotherTouched my cheeks and smiled.She was really simple. Fed on God for yearsAll her feasts were monotonousFor the only dish was always GodAnd the rest mere condiments.She told us how she rode her elephantWhen she was ten or elevenEvery Monday without failTo the Siva shrineAnd back to home againAnd, told us of the jewel boxAnd the brocade from the north          And the perfumes and the oilsAnd the sandal for her breastsAnd her marriage to a princeWho loved her deeply for a lovely short yearAnd died of fever, in her armsShe told usThat we had the oldest bloodMy brother and she and IThe oldest blood in the worldA blood thin and clear and fineWhile in the veins of the always poorAnd in the veinsOf the new- rich menFlowed a blood thick as gruelAnd muddy as a ditch.Finally she lay dyingIn her eighty sixth yearA woman wearied by compromiseHer legs quilted with arthritisAnd with only a hard coughFor comfortI looked deep into her eyesHer poor bleary eyesAnd prayed that she would not grieveSo much about the houseI had learnt by theMost lessons of defeat,Had found out that to grow richWas a difficult feat.The house was crouchingOn its elbows then,It looked that night in the pallid moonSo grotesque and alive.When they burnt my great grandmotherOver logs of the mango tree@I looked once at the house@And then again and again@For I thought I saw the windows close@Like the closing of the eyes@I thought I heard the pillars groan@And the dark rooms heave a sigh.@I set forth again@For other towns,@Left the house with the shrine@And the sands@And the flowering shrubs@And the wide rabid mouth of the Arabian Sea.@I know the rats are running now@Across the darkened halls@They do not fear the dead@I know the white ants have reached my home@And have raised on walls@          Strange totems of burial.@At night, in stillness,@ From every town I live in@I hear the rattle of its death@The noise of rafters creaking@And the windows’ whine.@I have let you down@Old house, I seek forgiveness@O mother’s mother’s mother@            I have plucked your soul@Like a pip from a fruit@And have flung it into your pyre@Call me callous@Call me selfish@ But do not blame my blood@So thin, so clear, so fine@The oldest blood in the world@That remembers as it flows@All the gems and all the gold@And all the perfumes and the oils@And the stately@";
            blood = blood.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), blood);
        }

        private void intro_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string intro = "I don’t know politics but I know the names@Of those in power, and can repeat them like@Days of week, or names of months, beginning with Nehru.@I amIndian, very brown, born inMalabar,@I speak three languages, write in@Two, dream in one.@Don’t write in English, they said, English is@Not your mother-tongue.Why not leave@Me alone, critics, friends, visiting cousins,@Every one of you? Why not let me speak in@Any language I like? The language I speak,@Becomes mine, its distortions, its queernesses@All mine, mine alone.@It is half English, halfIndian, funny perhaps, but it is honest,@It is as human as I am human, don’t@You see? It voices my joys, my longings, my@Hopes, and it is useful to me as cawing@Is to crows or roaring to the lions, it@Is human speech, the speech of the mind that is@Here and not there, a mind that sees and hears and@Of trees in storm or of monsoon clouds or of rain or the@Incoherent mutterings of the blazing@Funeral pyre.I was child, and later they@Told me I grew, for I became tall, my limbs@WhenI asked for love, not knowing what else to ask@For, he drew a youth of sixteen into the@Bedroom and closed the door, He did not beat me@But my sad woman - body felt so beaten.@The weight of my breasts and womb crushed me.@I shrank Pitifully.@Then … I wore a shirt and my@Brother’s trousers, cut my hair short and ignored@My womanliness.Dress in sarees, be girl@Be wife, they said.Be embroiderer, be cook,@Be a quarreller with servants.Fit in. Oh,@Belong, cried the categorizers.Don’t sit@On walls or peep in through our lace - draped windows.@Be Amy, or be Kamala.Or, better@Still, be Madhavikutty.It is time to@Choose a name, a role.Don’t play pretending games.Don’t play at schizophrenia or be @Nympho.Don’t cry embarrassingly loud when@Jilted in love … I met a man, loved him.Call@Him not by any name, he is every man@Who wants.a woman, just as I am every@Woman who seeks love.In him. . .the hungry haste@Of rivers, in me. . .the oceans’ tireless@Waiting.Who are you, I ask each and everyone,@The answer is, it is I.Anywhere and,@Everywhere, I see the one who calls himself I@In this world, he is tightly packed like the@Sword in its sheath.It is I who drink lonely@Drinks at twelve, midnight, in hotels of strange towns,@It is I who laugh, it is I who make love@And then, feel shame, it is I who lie dying@With a rattle in my throat.I am sinner,@I am saint.I am the beloved and the@Betrayed.I have no joys that are not yours, no@Aches which are not yours.I too call myself I.@";
            intro = intro.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), intro);
        }

        private void glass_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string glass = "Getting a man to love you is easyOnly be honest about your wants as@Woman.Stand nude before the glass with him@So that he sees himself the stronger one@And believes it so, and you so much more@Softer, younger, lovelier.Admit your@Admiration.Notice the perfection@Of his limbs, his eyes reddening under@The shower, the shy walk across the bathroom floor,@Dropping towels, and the jerky way he@Urinates.All the fond details that make@Him male and your only man. Gift him all,@Gift him what makes you woman, the scent of@Long hair, the musk of sweat between the breasts,@The warm shock of menstrual blood, and all your@Endless female hungers. Oh yes, getting@A man to love is easy, but living@Without him afterwards may have to be@Faced.A living without life when you move@Around, meeting strangers, with your eyes that@Gave up their search, with ears that hear only@His last voice calling out your name and your@Body which once under his touch had gleamed@Like burnished brass, now drab and destitute.@";
            glass = glass.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), glass);
        }

        private void the_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string the = "At sunset, on the river ban, KrishnaLoved her for the last time and left…@That night in her husband’s arms, Radha felt@So dead that he asked, What is wrong,@Do you mind my kisses, love ? And she said,@No, not at all, but thought, What is@It to the corpse if the maggots nip?@";
            the = the.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9),the);        
        }

        private void kris_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string kris = "Your body is my prison, Krishna,@I cannot see beyond it.@Your darkness blinds me,@Your love words shut out the wise world’s din.@";
            kris = kris.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), kris);

        }

        private void age_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string age = "Fond husband, ancient settler in the mind,@Old fat spider, weaving webs of bewilderment,@Be kind.You turn me into a bird of stone, a granite@Dove, you build round me a shabby room,@And stroke my pitted face absent - mindedly while@You read.With loud talk you bruise my pre - morning sleep,@You stick a finger into my dreaming eye. And@Yet, on daydreams, strong men cast their shadows, they sink@Like white suns in the swell of my Dravidian blood,@Secretly flow the drains beneath sacred cities.@When you leave, I drive my blue battered car@Along the bluer sea. I run up the forty@Noisy steps to knock at another’s door.@Though peep-holes, the neighbours watch,@they watch me come@And go like rain. Ask me, everybody, ask me@What he sees in me, ask me why he is called a lion,@A libertine, ask me why his hand sways like a hooded snake@Before it clasps my pubis.Ask me why like@A great tree, felled, he slumps against my breasts,@And sleeps. Ask me why life is short and love is@Shorter still, ask me what is bliss and what its price….@";
            age = age.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), age);
        }

        private void dance_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string dance = "It was hot, so hot, before the eunuchs came@To dance, wide skirts going round and round, cymbals@Richly clashing, and anklets jingling, jingling@Jingling… Beneath the fiery gulmohur, with@Long braids flying, dark eyes flashing, they danced and@They dance, oh, they danced till they bled… There were green@Tattoos on their cheeks, jasmines in their hair, some@Were dark and some were almost fair.Their voices@Were harsh, their songs melancholy; they sang of@Lovers dying and or children left unborn….@Some beat their drums; others beat their sorry breasts@@Were thin in limbs and dry; like half-burnt logs from@Funeral pyres, a drought and a rottenness@Were in each of them.Even the crows were so@Silent on trees, and the children wide - eyed, still;@All were watching these poor creatures’ convulsions@The sky crackled then, thunder came, and lightning@And rain, a meagre rain that smelt of dust in@Attics and the urine of lizards and mice….";
            dance = dance.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), dance);
        }
    }
}
