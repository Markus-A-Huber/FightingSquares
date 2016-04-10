using GameTest.Game;
using GameTest.Game.GameElements;
using GameTest.Game.GameElements.PlayerStates;
using GameTest.Game.MainFrame;
using GameTest.Game.MainFrame.GameModes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTest.WindowsForms
{
    public partial class QuickStartForm : Form
    {
        public bool Customize;
        public GameForm QuickGame;

        public QuickStartForm()
        {
            InitializeComponent();
            NoOfPlayers.SelectedIndex = 1;
            TeamNumber.SelectedIndex = 0;
            BotNumber.SelectedIndex = 2;
            Pickups.SelectedIndex = 2;
            GameMode.SelectedIndex = 1;
            Points.SelectedIndex = 0;
            Respawn.SelectedIndex = 1;
            Customize = false;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customize = true;
            DialogResult = DialogResult.OK;
        }

        private void StartQuickMatch_Click(object sender, EventArgs e)
        {
            var Lucky = new Random();
            List<Player> Players = new List<Player>();
            List<Fighter> Bots = new List<Fighter>();
            List<Team> Teams = new List<Team>();

            int RespawnTime = 10;
            int PickupTime = 10;
            //Respawn Time
            switch(Respawn.SelectedIndex)
            {
                case 0:
                    RespawnTime = 1;
                    break;
                case 1:
                    RespawnTime = 20;
                    break;
                case 2:
                    RespawnTime = 50;
                    break;
                case 3:
                    RespawnTime = 300;
                    break;
                case 4:
                    RespawnTime = int.MaxValue;
                    break;
            }
            //Pickup Time
            switch (Pickups.SelectedIndex)
            {
                case 0:
                    PickupTime = int.MaxValue;
                    break;
                case 1:
                    PickupTime = 300;
                    break;
                case 2:
                    PickupTime = 50;
                    break;
                case 3:
                    PickupTime = 20;
                    break;
                case 4:
                    PickupTime = 10;
                    break;
            }

            
            
            
            //The game
            Game.Game InternalGame = new Game.Game(30,20,RespawnTime,PickupTime,false, true, WeaponCeption.Checked);

            InternalGame.Width = Screen.PrimaryScreen.WorkingArea.Width;
            InternalGame.Height = Screen.PrimaryScreen.WorkingArea.Height;

            //Goal
            int points = 0;
            switch(Points.SelectedIndex)
            {
                case 0:
                    points = 50;
                    break;
                case 1:
                    points = 100;
                    break;
                case 2:
                    points = 200;
                    break;
                case 3:
                    points = 300;
                    break;
                case 4:
                    points = 500;
                    break;
                case 5:
                    points = 1000;
                    break;
            }
            //GameMode
            switch (GameMode.SelectedIndex)
            {
                case 0:
                    InternalGame.PlayMode = new FreeGame(InternalGame);
                    break;
                case 1:
                    InternalGame.PlayMode = new Deathmatch(InternalGame,points);
                    break;
                case 2:
                    InternalGame.PlayMode = new MoneyMaker(InternalGame,points);
                    break;
            }

            //Teams
            Dictionary<int, Color> TeamColors = new Dictionary<int, Color>();
            TeamColors.Add(0, Color.Red);
            TeamColors.Add(1, Color.Blue);
            TeamColors.Add(2, Color.Green);
            TeamColors.Add(3, Color.Orange);
            TeamColors.Add(4, Color.Violet);
            for (int i = 0; i < (TeamNumber.SelectedIndex + 2); i++)
            {
                InternalGame.Teams.Add(new Team(i, TeamColors[i]));
            }

            //Players
            switch (NoOfPlayers.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    //Player 1
                    Player Player1 = new Player(30, 30, 'A', InternalGame.Teams[0], true, InternalGame);
                    Player1.KeyBindings.Add(Keys.W, new MoveState(Player1, Direction.Up));
                    Player1.KeyBindings.Add(Keys.A, new MoveState(Player1, Direction.Left));
                    Player1.KeyBindings.Add(Keys.S, new MoveState(Player1, Direction.Down));
                    Player1.KeyBindings.Add(Keys.D, new MoveState(Player1, Direction.Right));
                    Players.Add(Player1);
                    break;
                case 2:
                    //Player 2
                    Player Player2 = new Player(InternalGame.Width - 40, InternalGame.Height - 40, 'B', InternalGame.Teams[1], true, InternalGame);
                    Player2.KeyBindings.Add(Keys.Up, new MoveState(Player2, Direction.Up));
                    Player2.KeyBindings.Add(Keys.Left, new MoveState(Player2, Direction.Left));
                    Player2.KeyBindings.Add(Keys.Down, new MoveState(Player2, Direction.Down));
                    Player2.KeyBindings.Add(Keys.Right, new MoveState(Player2, Direction.Right));
                    Players.Add(Player2);
                    goto case 1; //nice way to not double code
                case 3:
                    Player Player3 = new Player(30, InternalGame.Height - 40, 'C', InternalGame.Teams[2 % InternalGame.Teams.Count], true, InternalGame);
                    Player3.KeyBindings.Add(Keys.Z, new MoveState(Player3, Direction.Up));
                    Player3.KeyBindings.Add(Keys.G, new MoveState(Player3, Direction.Left));
                    Player3.KeyBindings.Add(Keys.H, new MoveState(Player3, Direction.Down));
                    Player3.KeyBindings.Add(Keys.J, new MoveState(Player3, Direction.Right));
                    Players.Add(Player3);
                    goto case 2;
                case 4:
                    Player Player4 = new Player(InternalGame.Width - 40, 30, 'D', InternalGame.Teams[3 % InternalGame.Teams.Count], true, InternalGame);
                    Player4.KeyBindings.Add(Keys.NumPad5, new MoveState(Player4, Direction.Up));
                    Player4.KeyBindings.Add(Keys.NumPad1, new MoveState(Player4, Direction.Left));
                    Player4.KeyBindings.Add(Keys.NumPad2, new MoveState(Player4, Direction.Down));
                    Player4.KeyBindings.Add(Keys.NumPad3, new MoveState(Player4, Direction.Right));
                    Players.Add(Player4);
                    goto case 3;
            }


            //Bots
            for (int i = 0; i<(BotNumber.SelectedIndex*10);i++)
            {
                for (int j = 0; j < InternalGame.Teams.Count; j++)
                    Bots.Add(new Fighter(Lucky.Next(50, InternalGame.Width - 50), Lucky.Next(50, InternalGame.Height - 50), InternalGame.Teams[j], InternalGame));
            }

            QuickGame = new GameForm(InternalGame, Players, Bots);
            Customize = false;
            DialogResult = DialogResult.OK;
        }
    }
}
