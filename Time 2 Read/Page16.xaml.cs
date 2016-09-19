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
    public sealed partial class Page16 : Page
    {
        public Page16()
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

        private void bear_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String bear = "Lightly, O lightly we bear her along,@She sways like a flower in the wind of our song;@She skims like a bird on the foam of a stream,@She floats like a laugh from the lips of a dream.@Gaily, O gaily we glide and we sing,@We bear her along like a pearl on a string.@Softly, O softly we bear her along,@She hangs like a star in the dew of our song;@She springs like a beam on the brow of the tide,@She falls like a tear from the eyes of a bride.@Lightly, O lightly we glide and we sing,@We bear her along like a pearl on a string.";
            bear = bear.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), bear);
        }

        private void bangle_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String bangle = "Bangle sellers are we who bear@Our shining loads to the temple fair...@Who will buy these delicate, brightRainbow - tinted circles of light?@Lustrous tokens of radiant lives,@For happy daughters and happy wives.@Some are meet for a maiden's wrist,@Silver and blue as the mountain mist,@Some are flushed like the buds that dream@On the tranquil brow of a woodland stream,@Some are aglow wth the bloom that cleaves@To the limpid glory of new born leaves@Some are like fields of sunlit corn,@Meet for a bride on her bridal morn,@Some, like the flame of her marriage fire,@Or, rich with the hue of her heart's desire,@Tinkling, luminous, tender, and clear,@Like her bridal laughter and bridal tear.@Some are purple and gold flecked grey@For she who has journeyed through life midway,@Whose hands have cherished, whose love has blest,@And cradled fair sons on her faithful breast,@And serves her household in fruitful pride,@And worships the gods at her husband's side.";
            bangle = bangle.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), bangle);
        }

        private void love_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String love = "He@@@@Lift up the veils that darken the delicate moon@of thy glory and grace,@Withhold not, O love, from the night@of my longing the joy of thy luminous face,@Give me a spear of the scented keora@guarding thy pinioned curls,@Or a silken thread from the fringes@that trouble the dream of thy glimmering pearls;@Faint grows my soul with thy tresses' perfume @and the song of thy anklets' caprice,@Revive me, I pray, with the magical nectar@that dwells in the flower of thy kiss.@@She@@How shall I yield to the voice of thy pleading, @how shall I grant thy prayer,@Or give thee a rose-red silken tassel,@a scented leaf from my hair?@Or fling in the flame of thy heart's desire the veils that cover my face,@Profane the law of my father's creed for a foe @of my father's race?@Thy kinsmen have broken our sacred altars and slaughtered our sacred kine,@The feud of old faiths and the blood of old battles sever thy people and mine.@@He@@What are the sins of my race, Beloved,@what are my people to thee?@And what are thy shrines, and kine and kindred, @what are thy gods to me?@Love recks not of feuds and bitter follies,@of stranger, comrade or kin,@Alike in his ear sound the temple bells@and the cry of the muezzin.@For Love shall cancel the ancient wrong@and conquer the ancient rage,@Redeem with his tears the memoried sorrow@that sullied a bygone age.";
            love = love.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), love);
        }

        private void weav_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String weav = "WEAVERS, weaving at break of day,@ Why do you weave a garment so gay?. . .@Blue as the wing of a halcyon wild,@ We weave the robes of a new- born child.Weavers, weaving at fall of night, @Why do you weave a garment so bright?. . .@Like the plumes of a peacock, purple and green, @We weave the marriage-veils of a queen.@Weavers, weaving solemn and still,@What do you weave in the moonlight chill? . . . @White as a feather and white as a cloud,@We weave a dead man's funeral shroud.";
            weav = weav.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), weav);
        }

        private void fish_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String fish = "Rise, brothers, rise; the wakening skies pray to the morning light,@The wind lies asleep in the arms of the dawn like a child that has cried all night.@Come, let us gather our nets from the shore and set our catamarans free,@ To capture the leaping wealth of the tide, for we are the kings of the sea!@No longer delay, let us hasten away in the track of the sea gull's call,@ The sea is our mother, the cloud is our brother, the waves are our comrades all.@What though we toss at the fall of the sun where the hand of the sea - god drives ?@He who holds the storm by the hair, will hide in his breast our lives.@Sweet is the shade of the cocoanut glade, and the scent of the mango grove,@And sweet are the sands at the full o' the moon with the sound of the voices we love;@ But sweeter, O brothers, the kiss of the spray and the dance of the wild foam's glee;@ Row, brothers, row to the edge of the verge, where the low sky mates with the sea.@";
            fish = fish.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), fish);
        }

        private void street_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String street = "WHEN dawn's first cymbals beat upon the sky,@ Rousing the world to labour's various cry, @To tend the flock, to bind the mellowing grain,@From ardent toil to forge a little gain, @And fasting men go forth on hurrying feet,@Buy bread, buy bread, rings down the eager street. @When the earth falters and the waters swoon@With the implacable radiance of noon,@And in dim shelters koyals hush their notes,@And the faint, thirsting blood in languid throats@Craves liquid succour from the cruel heat, @Buy fruit, buy fruit, steals down the panting street.@When twilight twinkling o'er the gay bazaars, @Unfurls a sudden canopy of stars,@When lutes are strung and fragrant torches lit@On white roof-terraces where lovers sit@Drinking together of life's poignant sweet,@Buy flowers, buy flowers, floats down the singing street.";
            street = street.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), street);
        }

        private void pain_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String pain = "Unwilling priestess in thy cruel fane@, Long hast thou held me, pitiless god of Pain,@Bound to thy worship by reluctant vows,@My tired breast girt with suffering, and my brows@Anointed with perpetual weariness.@Long have I borne thy service, through the stress@Of rigorous years, sad days and slumberless nights, @Performing thine inexorable rites. @For thy dark altars, balm nor milk nor rice,@But mine own soul thou'st ta'en for sacrifice: @All the rich honey of my youth's desire, @And all the sweet oils from my crushed life drawn,@And all my flower - like dreams and gem - like fire@Of hopes up - leaping like the light of dawn.@I have no more to give, all that was mine@Is laid, a wrested tribute, at thy shrine;@Let me depart, for my whole soul is wrung,@And all my cheerless orisons are sung;@Let me depart, with faint limbs let me creep@To some dim shade and sink me down to sleep.";
            pain = pain.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), pain);
        }

        private void singers_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String singers = "WHERE the voice of the wind calls our wandering feet,@ Through echoing forest and echoing street,@With lutes in our hands ever - singing we roam,@All men are our kindred, the world is our home.@Our lays are of cities whose lustre is shed, @The laughter and beauty of women long dead;@The sword of old battles, the crown of old kings, @And happy and simple and sorrowful things.@What hope shall we gather, what dreams shall we sow?@Where the wind calls our wandering footsteps we go. @No love bids us tarry, no joy bids us wait:@The voice of the wind is the voice of our fate.";
            singers = singers.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), singers);
        }

        private void autumn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String autumn = "Like a joy on the heart of a sorrow,@The sunset hangs on a cloud;@A golden storm of glittering sheaves,@Of fair and frail and fluttering leaves,@The wild wind blows in a cloud.@Hark to a voice that is calling@To my heart in the voice of the wind:@My heart is weary and sad and alone,@For its dreams like the fluttering leaves have gone,@And why should I stay behind@ ? ";
            autumn = autumn.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), autumn);
        }

        private void cradle_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String cradle = "From groves of spice,@ O'er fields of rice, @Athwart the lotus - stream, @I bring for you,@Aglint with dew@A little lovely dream.@Sweet, shut your eyes,@The wild fire - flies@Dance through the fairy neem;@From the poppy - bole@For you I stole@A little lovely dream.@Dear eyes, good - night,@In golden light@The stars around you gleam;@On you I press@With soft caress@A little lovely dream.";
            cradle = cradle.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), cradle);
        }

        private void Night_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String night = "SEE how the speckled sky burns like a pigeon's throat,@ Jewelled with embers of opal and peridote.@See the white river that flashes and scintillates,@Curved like a tusk from the mouth of the city - gates.@Hark, from the minaret, how the muezzin's call @Floats like a battle-flag over the city wall.@ From trellised balconies, languid and luminous@Faces gleam, veiled in a splendour voluminous.@Leisurely elephants wind through the winding lanes, @Swinging their silver bells hung from their silver chains.@Round the high Char Minar sounds of gay cavalcades@Blend with the music of cymbals and serenades.@Over the city bridge Night comes majestical, @Borne like a queen to a sumptuous festival.@A picture of The Charminar.This monument was built by the ruler of the Qutb Shahi dynasty who prayed when plague hit the city that if the black death left his city he would build a monument in gratitude. © by owner. provided at no charge for educational purposes@More ";
            night = night.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), night);
        }

        private void life_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String life = "CHILDREN, ye have not lived, to you it seems@ Life is a lovely stalactite of dreams,@Or carnival of careless joys that leapAbout your hearts like billows on the deep@In flames of amber and of amethyst.@Children, ye have not lived, ye but exist@Till some resistless hour shall rise and move@Your hearts to wake and hunger after love,@And thirst with passionate longing for the things@That burn your brows with blood - red sufferings.@Till ye have battled with great grief and fears,@And borne the conflict of dream - shattering years,@Wounded with fierce desire and worn with strife,@Children, ye have not lived: for this is life.";
            life = life.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), life);
        }

        private void india_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String india = "O YOUNG through all thy immemorial years!@ Rise, Mother, rise, regenerate from thy gloom,@And, like a bride high - mated with the spheres, @Beget new glories from thine ageless womb!@The nations that in fettered darkness weep@Crave thee to lead them where great mornings break . . . . @Mother, O Mother, wherefore dost thou sleep?@Arise and answer for thy children's sake! @Thy Future calls thee with a manifold sound@To crescent honours, splendours, victories vast;@Waken, O slumbering Mother and be crowned,@Who once wert empress of the sovereign Past.";
            india = india.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), india);
        }

        private void trans_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String trans = "Nay, do not grieve tho' life be full of sadness,@Dawn will not veil her splendour for your grief,@Nor spring deny their bright, appointed beauty@To lotus blossom and ashoka leaf.@Nay, do not pine, tho' life be dark with trouble,@Time will not pause or tarry on his way;@To - day that seems so long, so strange, so bitter,@Will soon be some forgotten yesterday.@Nay, do not weep; new hopes, new dreams, new faces,@The unspent joy of all the unborn years,@Will prove your heart a traitor to its sorrow,@And make your eyes unfaithful to their tears.";
            trans = trans.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), trans);
        }

        private void youth_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String youth = "O YOUTH, sweet comrade Youth, wouldst thou be gone?@ Long have we dwelt together, thou and I;@Together drunk of many an alien dawn, @And plucked the fruit of many an alien sky.@Ah, fickle friend, must I, who yesterday@Dreamed forwards to long, undimmed ecstasy, @Henceforward dream, because thou wilt not stay,@Backward to transient pleasure and to thee? @I give thee back thy false, ephemeral vow;@But, O beloved comrade, ere we part,@ Upon my mournful eyelids and my brow@Kiss me who hold thine image in my heart.";
                youth = youth.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), youth);
        }

        private void dead_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String dead = "HAVE YOU found me, at last, O my Dream? Seven eons ago@ You died and I buried you deep under forests of snow.@Why have you come hither? Who bade you awake from your sleep@And track me beyond the cerulean foam of the deep?@Would you tear from my lintels these sacred green garlands of leaves? @Would you scare the white, nested, wild pigeons of joy from my eaves?@Would you touch and defile with dead fingers the robes of my priest?@Would you weave your dim moan with the chantings of love at my feast?@Go back to your grave, O my Dream, under forests of snow,@ Where a heart - riven child hid you once, seven eons ago. @Who bade you arise from your darkness? I bid you depart!@Profane not the shrines I have raised in the clefts of my heart.";
            dead = dead.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), dead);
        }

        private void ecstasy_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String ecs = "Cover mine eyes, O my Love!@ Mine eyes that are weary of bliss@As of light that is poignant and strong@O silence my lips with a kiss, @My lips that are weary of song!@Shelter my soul, O my love!@My soul is bent low with the pain@And the burden of love, like the grace@Of a flower that is smitten with rain: @O shelter my soul from thy face!";
            ecs = ecs.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), ecs);
        }

        private void henna_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String henna = "A KOKILA called from a henna-spray:@ Lira!liree!Lira!liree!@Hasten, maidens, hasten away@To gather the leaves of the henna - tree.@Send your pitchers afloat on the tide,@Gather the leaves ere the dawn be old, @Grind them in mortars of amber and gold,@ The fresh green leaves of the henna - tree.@A kokila called from a henna-spray: @Lira!liree!Lira!liree!@Hasten maidens, hasten away@To gather the leaves of the henna - tree.@The tilka's red for the brow of a bride, @And betel-nut's red for lips that are sweet; @But, for lily - like fingers and feet,@The red, the red of the henna - tree.";
            henna = henna.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), henna);
        }

        private void parda_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String parda = "HER life is a revolving dream@ Of languid and sequestered ease;@Her girdles and her fillets gleam@Like changing fires on sunset seas;@Her raiment is like morning mist,@Shot opal, gold and amethyst.@From thieving light of eyes impure,@From coveting sun or wind's caress, @Her days are guarded and secure@Behind her carven lattices,@Like jewels in a turbaned crest, @Like secrets in a lover's breast. @But though no hand unsanctioned dares@Unveil the mysteries of her grace,@Time lifts the curtain unawares,@And Sorrow looks into her face. .@Who shall prevent the subtle years,@ Or shield a woman's eyes from tears?";
            parda = parda.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), parda);
        }

        private void poet_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String poet = "TARRY a while, O Death, I cannot die @While yet my sweet life burgeons with its spring;@Fair is my youth, and rich the echoing boughs@Where dhadikulas sing. @Tarry a while, O Death, I cannot die@With all my blossoming hopes unharvested,@My joys ungarnered, all my songs unsung, @And all my tears unshed.@Tarry a while, till I am satisfied@Of love and grief, of earth and altering sky;@Till all my human hungers are fulfilled, @O Death, I cannot die!";
            poet = poet.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), poet);
        }

        private void past_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String past = "The new hath come and now the old retires:@ And so the past becomes a mountain - cell, @Where lone, apart, old hermit - memories dwell@In consecrated calm, forgotten yet@Of the keen heart that hastens to forget@Old longings in fulfilling new desires.@And now the Soul stands in a vague, intense@Expectancy and anguish of suspense, @On the dim chamber-threshold. . .lo!he sees@Like a strange, fated bride as yet unknown, @His timid future shrinking there alone,@Beneath her marriage-veil of mysteries.";
            past = past.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), past);
        }

        private void gypsy_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String gypsy = "IN tattered robes that hoard a glittering trace @Of bygone colours, broidered to the knee,@Behold her, daughter of a wandering race, @Tameless, with the bold falcon's agile grace, @And the lithe tiger's sinuous majesty.@With frugal skill her simple wants she tends,@She folds her tawny heifers and her sheep@On lonely meadows when the daylight ends,@Ere the quick night upon her flock descends@Like a black panther from the caves of sleep.@Time's river winds in foaming centuries @Its changing, swift, irrevocable course@To far off and incalculable seas;@She is twin - born with primal mysteries,@And drinks of life at Time's forgotten source.";
            gypsy = gypsy.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), gypsy);
        }

        private void soul_Tapped(object sender, TappedRoutedEventArgs e)
        {
            String soul = " In childhood's pride I said to Thee:@  O Thou, who mad'st me of Thy breath,  @Speak, Master, and reveal to me@Thine inmost laws of life and death.@@Give me to drink each joy and pain  @Which Thine eternal hand can mete,@For my insatiate soul can drain@Earth's utmost bitter, utmost sweet. @@ Spare me no bliss, no pang of strife,  @Withhold no gift or grief I crave,  @The intricate lore of love and life@And mystic knowledge of the grave.@@  Lord, Thou didst answer stern and low:  @Child, I will hearken to thy prayer,  @And thy unconquered soul shall know@All passionate rapture and despair.@@Thou shalt drink deep of joy and fame, @And love shall burn thee like a fire,@And pain shall cleanse thee like a flame,  @To purge the dross from thy desire.@@So shall thy chastened spirit yearn  @To seek from its blind prayer release, @ And spent and pardoned, sue to learn@The simple secret of My peace. @@I, bending from my sevenfold height,  @Will teach thee of My quickening grace,  @Life is a prism of My light,@And Death the shadow of My face.";
            soul  = soul.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), soul);
        }
    }
}
