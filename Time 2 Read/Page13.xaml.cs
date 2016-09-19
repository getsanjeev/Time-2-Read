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
    public sealed partial class Page13 : Page
    {
        public Page13()
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

        private void song_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String song = "The breeze that visits heaven@And knows the planets seven,@The green spring with its flowery truth@Creative and the luminous heart of youth.@To all fair flowers and vernal@The wind makes melody diurnal.@On Ocean all night long@He rests, a voice of song.@The blue sea dances like a girl@With sapphire and with pearl@Crowning her locks.Sunshine and dew@Each morn delicious life renew.@The year is but a masque of flowers,@Of light and song and honied showers.@In the soft springtide comes the bird@Of heaven whose speech is one sweet word,@One word of sweet and magic power to bring@Green branches back and ruddy lights of spring.@@Of lily and rose and from the trees divinest greetings";
            song = song.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), song);
        }

        private void motion_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String motion = "Perfect thy motion ever within me,@Master of mind.@Grey of the brain, flash of the lightning,@Brilliant and blind,@These thou linkest, the world to mould,@Writing the thought in a scroll of gold@Violet - lined.@=Tablet of brain thou hast made for thy writing,@Master divine.@Calmly thou writest or full of thy grandeur@Flushed as with wine,@Then with a laugh thou erasest the scroll,@Bringing another, like waves that roll@And sink supine.";
            motion  = motion.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), motion);
       
        }

        private void alpha_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String alpha = "Ye weeping poplars by the shelvy slope@ From murmurous lawns down-dropping to the stream@On whom the dusk air like a sombre dream@Broods and a twilight ignorant of hope,@Say what compulsion drear has bid you seam@Your mossy sides with drop on eloquent drop@That in warm rillets from your eyes elope ?@Is it for the too patient sure decay@Pale - gilded Autumn, aesthete of the years,@A gorgeous death, a fading glory wears@That thus along the tufted, downy way@Creep slothfully this ooze of amber tears@And thus with tearful gusts your branches sway@Sighing a requiem to your emerald day@";
            alpha = alpha.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), alpha);
        }

        private void hero_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String hero = "My life is then a wasted ereme,@My song but idle wind@Because you merely find@In all this woven wealth of rhyme@Harsh figures with harsh music wound,@The uncouth voice of gorgeous birds,@A ruby carcanet of sound,@A cloud of lovely words?@I am, you say, no magic - rod,@No cry oracular,@No swart and ominous star,@No Sinai-thunder voicing God,@I have no burden to my song,@No smouldering word instinct with fire,@No spell to chase triumphant wrong,@No spirit - sweet desire.@ Mine is not Byron's lightning spear,@Nor Wordsworth's lucid strain@Nor Shelley's lyric pain,@Nor Keats', the poet without peer.@I by the Indian waters vast@Did glimpse the magic of the past,@And on the oaten-pipe I play@Warped echoes of an earlier day@@@My friend, when first my spirit woke,@I trod the scented maze@Of Fancy's myriad ways,@I studied Nature like a book@Men rack for meanings; yet I find@No rubric in the scarlet rose,@No moral in the murmuring wind,@No message in the snows.@For me the daisy shines a star,@The crocus flames a spire,@A horn of golden fire,@Narcissus glows a silver bar:@Cowslips, the golden breath of God,@I deem the poet's heritage,@And lilies silvering the sod@Breathe fragrance from his page.@No herald of the Sun am I,@But in a moon - lit veil@A russet nightingale@Who pours sweet song, he knows not why,@Who pours like a wine a gurgling note@Paining with sound his swarthy throat,@Who pours sweet song, he recks not why,@Nor hushes ever lest he die.";
            hero = hero.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), hero);
        }

        private void est_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String est = "Why do thy lucid eyes survey,@Estelle, their sisters in the milky way?@The blue heavens cannot see@Thy beauty nor the planets praise.@Blindly they walk their old accustomed ways.@Turn hither for felicity.@My body's earth thy vernal power declares,@My spirit is a heaven of thousand stars,@And all these lights are thine and open doors on thee.";
            est = est.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), est);
        }

        private void jacet_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String jacet = "Patriots, behold your guerdon. This man found@Erin, his mother, bleeding, chastised, bound,@Naked to imputation, poor, denied,@While alien masters held her house of pride.@And now behold her!Terrible and fair@With the eternal ivy in her hair,@Armed with the clamorous thunder, how she stands@Like Pallas' self, the Gorgon in her hands.@True that her puissance will be easily past,@The vision ended; she herself has cast@Her fate behind her: yet the work not vain@Since that which once has been may be again,@And she this image yet recover, fired@With godlike workings, brain and hands inspired,@So stand, the blush of battle on her cheek,@Voice made armipotent, deeds that loudly speak,@Like some dread Sphinx, half patent to the eye,@Half veiled in formidable secrecy.@And he who raised her from her forlorn life@Loosening the fountains of that mighty strife,@Where sits he? On what high foreshadowing throne@Guarded by grateful hearts? Beneath this stone@He lies: this guerdon only Ireland gave,@A broken heart and an unhonoured grave.";
            jacet = jacet.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), jacet);
        }

        private void reve_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String reve = "Someone leaping from the rocks@Past me ran with windblown@locks Like a startled bright surmise@Visible to mortal eyes, —@Just a cheek of frightened rose@That with sudden beauty glows,@Just a footstep like the wind@And a hurried glance behind,@And then nothing, — as a thought@Escapes the mind ere it is caught.@Someone of the heavenly rout@From behind the veil ran out.@";
            reve = reve.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), reve);
        }

        private void bird_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String bird = "I am the bird of God in His blue@Divinely high and clear@I sing the notes of the sweet and the true@For the god's and the seraph's ear.@I rise like a fire from the mortal's earth@Into a griefless sky@And drop in the suffering soil of his birth@Fire - seeds of ecstasy.@My pinions soar beyond Time and Space@Into unfading Light;@I bring the bliss of the Eternal's face@And the boon of the Spirit's sight.@I measure the worlds with my ruby eyes;@I have perched on Wisdom's tree@Thronged with the blossoms of Paradise@By the streams of Eternity.@Nothing is hid from my burning heart;@My mind is shoreless and still;@My song is rapture's mystic art,@My flight immortal will.";
            bird = bird.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), bird);
        }

        private void bridge_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String bridge = "Bride of the Fire, clasp me now close,@Bride of the Fire!@I have shed the bloom of the earthly rose,@I have slain desire.@Beauty of the Light, surround my life, -@Beauty of the Light!@I have sacrificed longing and parted from grief,@I can bear thy delight.@Image of Ecstasy, thrill and enlace,@Image of Bliss!@I would see only thy marvellous face,@Feel only thy kiss.@Voice of Infinity, sound in my heart,@Call of the One!@Stamp there thy radiance, never to part,@O living sun.";
            bridge =  bridge.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), bridge);
        }

        private void sri_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String sri = "O immense Light and thou, O spirit-wide boundless Space,@Whom have you clasped and hid, deathless limbs, gloried face?@Vainly lie 'Space and Time, Void are we, there is none.@Vainly strive Self and World crying, I, I alone.@One is there, Self of self, Soul of space, Fount of Time,@Heart of hearts, Mind of minds, He alone sits, sublime.@Oh, no void Absolute self - absorbed, splendid, mute,@Hands that clasp hold and red lips that kiss blow the flute.@All He loves, all He moves, all are His, all are He!@Many limbs sate His whims, hear His sweet ecstasy.Two in One, Two who know difference rich in sense,@Two to clasp, One to be, this His strange mystery.";
                sri = sri.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), sri);
        }

        private void call_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String call = "There is a godhead of unrealised things@To which Time's splendid gains are hoarded dross;@A cry seems near, a rustle of silver wings@Calling to heavenly joy by earthly loss.@All eye has seen and all the ear has heard@Is a pale illusion by some greater voice@And mightier vision; no sweet sound or word,@No passion of hues that make the heart rejoice@Can equal these diviner ecstasies.@A Mind beyond our mind has sole the ken@Of those yet unimagined harmonies,@The fate and privilege of unborn men.@As rain-thrashed mire the marvel of the rose,@Earth waits that distant marvel to disclose.";
            call = call.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), sri);
        }

        private void god_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String god = "I have gathered my dreams in a silver air@Between the gold and the blue@And wrapped them softly and left them there,@My jewelled dreams of you.@I had hoped to build a rainbow bridge@Marrying the soil to the sky@And sow in this dancing planet midge@The moods of infinity.@But too bright were our heavens, too far away,@Too frail their ethereal stuff;@Too splendid and sudden our light could not stay;@The roots were not deep enough.@He who would bring the heavens here@Must descend himself into clay@And the burden of earthly nature bear@And tread the dolorous way.@Coercing my godhead I have come down@Here on the sordid earth,@Ignorant, labouring, human grown@Twixt the gates of death and birth.";
            god = god.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), god);
        }

    }
}
