using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SoundBox
{
    public partial class Form1 : Form
    {
        SoundPlayer SplashSFX = new SoundPlayer(Properties.Resources.Splash);
        SoundPlayer SirenSFX = new SoundPlayer(Properties.Resources.Siren);
        SoundPlayer ShortMatchSFX = new SoundPlayer(Properties.Resources.Short_March);
        SoundPlayer PowerUpSFX = new SoundPlayer(Properties.Resources.PowerUp);
        SoundPlayer MarchingSFX = new SoundPlayer(Properties.Resources.Marching);
        SoundPlayer ExplosionSFX = new SoundPlayer(Properties.Resources.Explosion);
        SoundPlayer BalloonSFX = new SoundPlayer(Properties.Resources.Balloon);
        SoundPlayer BalloonBoomSFX = new SoundPlayer(Properties.Resources.Balloon_Blowing_Up);
        SoundPlayer ChompSFX = new SoundPlayer(Properties.Resources.Chomp);
        SoundPlayer CarCrashSFX = new SoundPlayer(Properties.Resources.CarCrash);
        SoundPlayer SwordSwingSFX = new SoundPlayer(Properties.Resources.Sword_Swoosh);
        SoundPlayer CoinSFX = new SoundPlayer(Properties.Resources.Coin);
        /*---------------------------------------------------------------------------------------------------------*///divider for  sound


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CoinButton_Click(object sender, EventArgs e)
        {
            CoinSFX.Play();
        }

        private void sword_swoosh_sfx_Click(object sender, EventArgs e)
        {
            SwordSwingSFX.Play();
        }

        private void Car_Crash_SFX_Click(object sender, EventArgs e)
        {
            CarCrashSFX.Play();
        }

        private void Chomp_SFX_Click(object sender, EventArgs e)
        {
            ChompSFX.Play();
        }
    }
}
