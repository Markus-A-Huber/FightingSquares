using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameTest.Game.Weapons;
using GameTest.Game;
using GameTest.Game.GameElements;
using GameTest.Game.PickUps;
using GameTest.Game.GameElements.PlayerStates;

namespace GameTest.WindowsForms.GameBuilderForm.UserControls
{
    public partial class CustomizePlayerControl : UserControl
    {
        
        Keys[] UserKeys;
        Button CurrentlyActiveButton;
        
        int weaponCounter;
        Dictionary<int, Bitmap> WeaponToInt;
        Dictionary<int, Weapon> IntToWeapon;
        Game.Game TheGame;
        Team CurrentTeam;
        Player player;
        public CustomizePlayerControl(Game.Game Game, Team CurrentTeam)
        {
            InitializeComponent();
            UserKeys = new Keys[] { Keys.Up, Keys.Down, Keys.Left, Keys.Right };
            WeaponToInt = new Dictionary<int, Bitmap>();
            Random r = new Random();
            weaponCounter = 0;
            WeaponToInt.Add(0, Images.PistolPickup);
            WeaponToInt.Add(1, Images.CannonPickup);
            WeaponToInt.Add(2, Images.FlamethrowerPickup);
            WeaponToInt.Add(3, Images.TentaclePickup);
            WeaponToInt.Add(4, Images.RocketLauncherPickup);
            WeaponToInt.Add(5, Images.TwisterPickup);
            WeaponToInt.Add(6, Images.WingsPickup);
            TheGame = Game;
            player = new Player(r.Next(30, TheGame.Width - 40), r.Next(30, TheGame.Height - 40), Symbol.Text[0], CurrentTeam, true, TheGame);
            player.Shielded = true;

            IntToWeapon = new Dictionary<int, Weapon>();
            IntToWeapon.Add(0, new Pistol(TheGame,player));
            IntToWeapon.Add(1, new Cannon(TheGame,player));
            IntToWeapon.Add(2, new Flamethrower(TheGame, player));
            IntToWeapon.Add(3, new Tentacles(TheGame, player));
            IntToWeapon.Add(4, new RocketLauncher(TheGame, player));
            IntToWeapon.Add(5, new Twister(TheGame, player));
            IntToWeapon.Add(6, new Wings(TheGame, player));

            weapon.BackgroundImage = WeaponToInt[weaponCounter];

            
            this.CurrentTeam = CurrentTeam;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Press Key";
            CurrentlyActiveButton = button1;
        }

        private void Symbol_Click(object sender, EventArgs e)
        {
            //ASCII chars A - Z
            //65 -> 90
            //Symbol.Text = ((char)(((((int)Symbol.Text[0]) - 65) + 1) % 26 + 65)).ToString();
        }

        private void CustomizePlayerControl_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
                UserKeys[0] = e.KeyCode;
                button1.Text = e.KeyCode.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Press Key";
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            UserKeys[1] = e.KeyCode;
            button2.Text = e.KeyCode.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Press Key";
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            UserKeys[2] = e.KeyCode;
            button3.Text = e.KeyCode.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "Press Key";
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            UserKeys[3] = e.KeyCode;
            button4.Text = e.KeyCode.ToString();
        }

        private void Symbol_MouseDown(object sender, MouseEventArgs e)
        {
            //ASCII chars A - Z
            //65 -> 90
            if (e.Button == MouseButtons.Left)
                Symbol.Text = ((char)(((((int)Symbol.Text[0]) - 65) + 1) % 26 + 65)).ToString();
            else if (e.Button == MouseButtons.Right)
            {
                int temp = (((int)Symbol.Text[0]) - 65) - 1;
                if (temp < 0)
                    temp = 25;
                Symbol.Text = ((char)(temp-- + 65)).ToString();
            }
        }

        private void weapon_Click(object sender, EventArgs e)
        {

        }

        private void weapon_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                weaponCounter = (++weaponCounter) % (WeaponToInt.Count);
            else if (e.Button == MouseButtons.Right)
                if (--weaponCounter < 0)
                    weaponCounter = WeaponToInt.Count-1;

          
            weapon.BackgroundImage = WeaponToInt[weaponCounter];
            weapon.Refresh();
        }

        public Player returnPlayer()
        {
            player.KeyBindings.Add(UserKeys[0], new MoveState(player, Direction.Up));
            player.KeyBindings.Add(UserKeys[1], new MoveState(player, Direction.Down));
            player.KeyBindings.Add(UserKeys[2], new MoveState(player, Direction.Left));
            player.KeyBindings.Add(UserKeys[3], new MoveState(player, Direction.Right));
            player.CurrentWeapon = IntToWeapon[weaponCounter];
            player.Symbol = Symbol.Text[0];
            return player;
        }
    }
}
