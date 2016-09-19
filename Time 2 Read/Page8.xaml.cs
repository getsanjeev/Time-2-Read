using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.Storage;
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
    public sealed partial class Page8 : Page
    {
        public Page8()
        {
            this.InitializeComponent();
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }
        void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                e.Handled = true;
                Frame.GoBack();
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void mind_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string fear = "Where the mind is without fear and the head is held high@Where knowledge is free@where the world has not been broken up@into fragments by narrow domestic walls@Where words come out from the depth of truth@Where tireless striving stretches its arms towards perfection@ Where the clear stream of reason@has not lost its way into the dreary desert sand of dead habit@Where the mind is led forward by thee into ever - widening thought and action@Into that heaven of freedom, my Father, let my country awake.";
            
            fear = fear.Replace("@",  System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), fear);
        }

        private void litle_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string mind = "Thou hast made me endless, such is thy pleasure.@ This frail vessel thou emptiest again and again, and fillest it ever with fresh life.@This little flute of a reed thou hast carried over hills and dales,@and hast breathed through it melodies eternally new.@At the immortal touch of thy hands my little heart loses its limits in@joy and gives birth to utterance ineffable.@Thy infinite gifts come to me only on these very small hands of mine.@Ages pass, and still thou pourest, and still there is room to fill.";
            mind = mind.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), mind);

        }

        private void purity_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string purity = "Life of my life, I shall ever try to keep my body pure, knowing@that thy living touch is upon all my limbs.@I shall ever try to keep all untruths out from my thoughts, knowing@that thou art that truth which has kindled the light of reason in my mind.@I shall ever try to drive all evils away from my heart and keep my@love in flower, knowing that thou hast thy seat in the inmost shrine of my heart.@And it shall be my endeavour to reveal thee in my actions, knowing it@is thy power gives me strength to act.";
            purity = purity.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), purity);
        }

        private void mom_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string mom = "I ask for a moment's indulgence to sit by thy side. The works@that I have in hand I will finish afterwards.@Away from the sight of thy face my heart knows no rest nor respite,@and my work becomes an endless toil in a shoreless sea of toil.@Today the summer has come at my window with its sighs and murmurs; and@the bees are plying their minstrelsy at the court of the flowering grove.@Now it is time to sit quite, face to face with thee, and to sing@dedication of life in this silent and overflowing leisure.";
            mom = mom.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), mom);
        }

        private void flower_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string flower = "Pluck this little flower and take it, delay not! I fear lest itdroop and drop into the dust.@I may not find a place in thy garland, but honour it with a touch of@pain from thy hand and pluck it.I fear lest the day end before I am@aware, and the time of offering go by.@Though its colour be not deep and its smell be faint, use this flower@in thy service and pluck it while there is time.@";
            flower = flower.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), flower);
        }

        private void Fool_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string fool = "O Fool, try to carry thyself upon thy own shoulders!O beggar, to come beg at thy own door!@Leave all thy burdens on his hands who can bear all,@and never look behind in regret.@Thy desire at once puts out the light from the lamp it touches with its breath.@It is unholy---take not thy gifts through its unclean hands.@Accept only what is offered by sacred love.@";
            fool = fool.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), fool);
        }

        private void Leave_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string leave = "Leave this chanting and singing and telling of beads!Whom dost thou worship in this lonely dark corner of a temple with doors all shut?Open thine eyes and see thy God is not before thee!@He is there where the tiller is tilling the hard ground@and where the pathmaker is breaking stones.@He is with them in sun and in shower,@and his garment is covered with dust.@Put off thy holy mantle and even like him come down on the dusty soil!@";
            leave = leave.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9),leave);
        }

        private void del_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string del = "Where is this deliverance to be found?@Our master himself has joyfully taken upon him the bonds of creation;@he is bound with us all for ever.@Come out of thy meditations and leave aside thy flowers and incense!@What harm is there if thy clothes become tattered and stained?Meet him and stand by him in toil and in sweat of thy brow.@";
            del = del.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), del);
        }

        private void jou_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string jou = "The time that my journey takes is long and the way of it long.@I came out on the chariot of the first gleam of light, and pursued my@voyage through the wildernesses of worlds leaving my track on many a star and planet.@It is the most distant course that comes nearest to thyself,@and that training is the most intricate which leads to the utter simplicity of a tune.@The traveler has to knock at every alien door to come to his own,@and one has to wander through all the outer worlds to reach the innermost shrine at the end.@My eyes strayed far and wide before I shut them and said `Here art thou!'@The question and the cry `Oh, where ? ' melt into tears of a thousand@streams and deluge the world with the flood of the assurance `I am!";
            jou = jou.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), jou);
        }

        private void song_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string song = "The song that I came to sing remains unsung to this day.@I have spent my days in stringing and in unstringing my instrument.@The time has not come true, the words have not been rightly set;@only there is the agony of wishing in my heart.@The blossom has not opened; only the wind is sighing by.@I have not seen his face, nor have I listened to his voice;@only I have heard his gentle footsteps from the road before my house.@The livelong day has passed in spreading his seat on the floor;@but the lamp has not been lit and I cannot ask him into my house.@I live in the hope of meeting with him; but this meeting is not yet.@";
            song = song.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), song);
        }

        private void mercy_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string mercy = "My desires are many and my cry is pitiful,@but ever didst thou save me by hard refusals;@and this strong mercy has been wrought into my life through and through.@Day by day thou art making me worthy of the simple,@great gifts that thou gavest to me unasked---this sky and the light, this body and the@life and the mind-- - saving me from perils of overmuch desire.@There are times when I languidly linger@and times when I awaken and hurry in search of my goal;@but cruelly thou hidest thyself from before me.@Day by day thou art making me worthy of thy full acceptance by@refusing me ever and anon, saving me from perils of weak, uncertain desire.@";
            mercy = mercy.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), mercy);
        }

        private void pat_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string pat = "If thou speakest not I will fill my heart with thy silence and endure it.I will keep still and wait like the night with starry vigil@and its head bent low with patience.@The morning will surely come, the darkness will vanish,@and thy voice pour down in golden streams breaking through the sky.@Then thy words will take wing in songs from every one of my birds' nests,@and thy melodies will break forth in flowers in all my forest groves.@";
            pat  =pat.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), pat);
        }

        private void fire_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string fire = "I touch God in my song@as the hill touches the far-away sea@with its waterfall.@The butterfly counts not months but moments,@and has time enough.@Let my love, like sunlight, surround you@Love remains a secret even when spoken,@for only a lover truly knows that he is loved.@Emancipation from the bondage of the soil@is no freedom for the tree.@In love I pay my endless debt to thee@for what thou art.@";
            fire =fire.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), fire);
        }

        private void sail_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string sail = "Early in the day it was whispered that we should sail in a boat,@only thou and I, and never a soul in the world would know of this our@pilgrimage to no country and to no end.@In that shoreless ocean,@at thy silently listening smile my songs would swell in melodies,@free as waves, free from all bondage of words.@Is the time not come yet?@Are there works still to do?@Lo, the evening has come down upon the shore@and in the fading light the seabirds come flying to their nests.@Who knows when the chains will be off,@and the boat, like the last glimmer of sunset,@vanish into the night?@";
            sail = sail.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), sail);
        }

        private void signet_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string eter = "The day was when I did not keep myself in readiness for thee;@and entering my heart unbidden even as one of the common crowd,@unknown to me, my king, thou didst press the signet of eternity upon@many a fleeting moment of my life.@And today when by chance I light upon them and see thy signature,@I find they have lain scattered in the dust mixed with the memory of@joys and sorrows of my trivial days forgotten.@Thou didst not turn in contempt from my childish play among dust,@and the steps that I heard in my playroom@are the same that are echoing from star to star.@Where Shadow Chases Light@This is my delight,@thus to wait and watch at the wayside@where shadow chases light@and the rain comes in the wake of the summer.@Messengers, with tidings from unknown skies,@greet me and speed along the road.@My heart is glad within,@and the breath of the passing breeze is sweet.@From dawn till dusk I sit here before my door,@and I know that of a sudden@the happy moment will arrive when I shall see.@In the meanwhile I smile and I sing all alone.@In the meanwhile the air is filling with the perfume of promise.@";
            eter = eter.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), eter);
        }

        private void step_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string step = "Have you not heard his silent steps?@He comes, comes, ever comes.@Every moment and every age,@every day and every night he comes, comes, ever comes.@Many a song have I sung in many a mood of mind,@but all their notes have always proclaimed,@`He comes, comes, ever comes.@In the fragrant days of sunny April through the forest path he comes,@comes, ever comes.@In the rainy gloom of July nights on the thundering chariot of clouds@he comes, comes, ever comes.@In sorrow after sorrow it is his steps that press upon my heart,@and it is the golden touch of his feet that makes my joy to shine.@";
            step = step.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), step);
        }

        private void time_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string time = "I know not from what distant time@thou art ever coming nearer to meet me.@Thy sun and stars can never keep thee hidden from me for aye.@In many a morning and eve thy footsteps have been heard@and thy messenger has come within my heart and called me in secret.@I know not only why today my life is all astir,@and a feeling of tremulous joy is passing through my heart.@It is as if the time were come to wind up my work,@and I feel in the air a faint smell of thy sweet presence.@";
            time = time.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), time);
        }

        private void toy_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string toy = "When I bring to you colored toys, my child,@I understand why there is such a play of colors on clouds, on water,@and why flowers are painted in tints@-- - when I give colored toys to you, my child.@ When I sing to make you dance@ I truly now why there is music in leaves,@and why waves send their chorus of voices to the heart of the listening earth@-- - when I sing to make you dance.@When I bring sweet things to your greedy hands@I know why there is honey in the cup of the flowers@and why fruits are secretly filled with sweet juice@---when I bring sweet things to your greedy hands.@When I kiss your face to make you smile, my darling,@I surely understand what pleasure streams from the sky in morning light,@and what delight that is that is which the summer breeze brings to my body-- - when I kiss you to make you smile.";
            toy = toy.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), toy);
        }

        private void she_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string she = "She who ever had remained in the depth of my being,@in the twilight of gleams and of glimpses;@she who never opened her veils in the morning light,@will be my last gift to thee, my God, folded in my final song.@Words have wooed yet failed to win her;@persuasion has stretched to her its eager arms in vain.@I have roamed from country to country keeping her in the core of my heart,@and around her have risen and fallen the growth and decay of my life.@Over my thoughts and actions, my slumbers and dreams,@she reigned yet dwelled alone and apart.@Many a man knocked at my door and asked for her@and turned away in despair.@There was none in the world who ever saw her face to face,@and she remained in her loneliness waiting for thy recognition.@";
            she = she.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), she);
        }

        private void let_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string let = "If it is not my portion to meet thee in this life@then let me ever feel that I have missed thy sight@-- - let me not forget for a moment,@let me carry the pangs of this sorrow in my dreams@and in my wakeful hours.@As my days pass in the crowded market of this world@and my hands grow full with the daily profits,@let me ever feel that I have gained nothing@let me carry the pangs of this sorrow in my dreams@and in my wakeful hours.@When I sit by the roadside, tired and panting,@when I spread my bed low in the dust,@let me ever feel that the long journey is still before me@-- - let me not forget a moment,@let me carry the pangs of this sorrow in my dreams@and in my wakeful hours.@When my rooms have been decked out and the flutes sound@and the laughter there is loud,@let me ever feel that I have not invited thee to my house@-- - let me not forget for a moment,@let me carry the pangs of this sorrow in my dreams@and in my wakeful hours.@";
            let = let.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), let);
        }

        private void last_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string last = "I know that the day will come@when my sight of this earth shall be lost,@and life will take its leave in silence,@drawing the last curtain over my eyes.@Yet stars will watch at night,@and morning rise as before,@and hours heave like sea waves casting up pleasures and pains.@When I think of this end of my moments,@the barrier of the moments breaks@and I see by the light of death@thy world with its careless treasures.@rare is its meanest of lives.@Things that I longed for in vain@and things that I got@Let me but truly possess@the things that I ever spurned@and overlooked.@";
            last = last.Replace("@", System.Environment.NewLine);
            Frame.Navigate(typeof(Page9), last);
        }
    }
       
           
        

    }



