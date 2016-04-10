using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameTest.Game;
using GameTest.Game.GameElements;
using GameTest.Game.Weapons;

namespace GameTest.WindowsForms.GameBuilderForm.UserControls
{
    public partial class CustomizeBotControl : UserControl
    {
        int weaponCounter;
        Game.Game TheGame;
        Dictionary<int, Bitmap> WeaponToInt;
        Team CurrentTeam;
        public CustomizeBotControl(Game.Game Game, Team CurrentTeam)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            WeaponToInt = new Dictionary<int, Bitmap>();
            weaponCounter = 0;
            WeaponToInt.Add(0, Images.PistolPickup);
            WeaponToInt.Add(1, Images.CannonPickup);
            WeaponToInt.Add(2, Images.FlamethrowerPickup);
            WeaponToInt.Add(3, Images.TentaclePickup);
            WeaponToInt.Add(4, Images.RocketLauncherPickup);
            WeaponToInt.Add(5, Images.TwisterPickup);
            WeaponToInt.Add(6, Images.WingsPickup);
            button1.BackgroundImage = WeaponToInt[weaponCounter];
            TheGame = Game;
            this.CurrentTeam = CurrentTeam;
        }

        public List<Fighter> returnBots()
        {
            Random r = new Random(Environment.TickCount+CurrentTeam.TeamNumber);
            var Elements = new List<Fighter>();
            for (int i = 0; i < int.Parse(comboBox1.Text); i++)
            {
                var f = new Fighter(r.Next(30, TheGame.Width - 40), r.Next(30, TheGame.Height - 40), CurrentTeam, TheGame);
                switch(weaponCounter)
                {
                    case 0:
                        f.CurrentWeapon = new Pistol(TheGame, f);
                        break;
                    case 1:
                        f.CurrentWeapon = new Cannon(TheGame, f);
                        break;
                    case 2:
                        f.CurrentWeapon = new Flamethrower(TheGame, f);
                        break;
                    case 3:
                        f.CurrentWeapon = new Tentacles(TheGame, f);
                        break;
                    case 4:
                        f.CurrentWeapon = new Flamethrower(TheGame, f);
                        break;
                    case 5:
                        f.CurrentWeapon = new Twister(TheGame, f);
                        break;
                    case 6:
                        f.CurrentWeapon = new Wings(TheGame, f);
                        break;
                }
                
                Elements.Add(f);
            }
                
            return Elements;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                weaponCounter = (++weaponCounter) % (WeaponToInt.Count);
            else if (e.Button == MouseButtons.Right)
                if (--weaponCounter < 0)
                    weaponCounter = WeaponToInt.Count - 1;


            button1.BackgroundImage = WeaponToInt[weaponCounter];
            button1.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
