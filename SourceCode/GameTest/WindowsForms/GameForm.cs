using GameTest.Game;
using GameTest.Game.GameElements;
using GameTest.Game.GameElements.PlayerStates;
using GameTest.Game.PickUps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTest.WindowsForms
{
    
    public partial class GameForm : Form
    {
        SynchronizationContext context;
        private Game.Game RunningGame;
        int MouseX = 0;
        int MouseY = 0;
        /*
        public GameForm(Game.Game G)
        {
            context = SynchronizationContext.Current;
            
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            RunningGame = G;
            RunningGame.Render.ImageUpdated += Render_ImageUpdated;
            RunningGame.Width = Screen.PrimaryScreen.WorkingArea.Width;
            RunningGame.Height = Screen.PrimaryScreen.WorkingArea.Height;

            //Player 1
            Player Player1 = new Player(30, 30, 'M' , RunningGame.Teams[0],true, RunningGame);
            Player1.KeyBindings.Add(Keys.W, new MoveState(Player1, Direction.Up));
            Player1.KeyBindings.Add(Keys.A, new MoveState(Player1, Direction.Left));
            Player1.KeyBindings.Add(Keys.S, new MoveState(Player1, Direction.Down));
            Player1.KeyBindings.Add(Keys.D, new MoveState(Player1, Direction.Right));
            AddPlayerToGame(Player1);

            //Player 2
            Player Player2 = new Player(RunningGame.Width - 40, RunningGame.Height - 40, 'C', RunningGame.Teams[1],  true, RunningGame);
            Player2.KeyBindings.Add(Keys.Up, new MoveState(Player2, Direction.Up));
            Player2.KeyBindings.Add(Keys.Left, new MoveState(Player2, Direction.Left));
            Player2.KeyBindings.Add(Keys.Down, new MoveState(Player2, Direction.Down));
            Player2.KeyBindings.Add(Keys.Right, new MoveState(Player2, Direction.Right));
            AddPlayerToGame(Player2);
            
            
            
        }*/

        public GameForm(Game.Game G, List<Player> Players, List<Fighter> Bots)
        {
            context = SynchronizationContext.Current;

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            RunningGame = G;
            RunningGame.Render.ImageUpdated += Render_ImageUpdated;
            RunningGame.Width = Screen.PrimaryScreen.WorkingArea.Width;
            RunningGame.Height = Screen.PrimaryScreen.WorkingArea.Height;

            foreach (Player p in Players)
                AddPlayerToGame(p);

            foreach (Fighter Bot in Bots)
                RunningGame.InitialBots.Add(Bot);

            RunningGame.Start();
        }

        public void AddPlayerToGame(Player p)
        {
            this.KeyDown += p.reactToKeyDown;
            this.KeyUp += p.reactToKeyUp;
            pictureBox1.MouseDown += p.reactToMouseDown;
            pictureBox1.MouseUp += p.reactToMouseUp;
            pictureBox1.MouseMove += p.reactToMouseMove;

            RunningGame.UserControlledPlayers.Add(p);
        }

        private void Render_ImageUpdated(object sender, Game.ImageDrawnEventArgs e)
        {
            try
            { 
                    context.Send(o =>
                   {
                       pictureBox1.Image = e.Image;
                       pictureBox1.Refresh();
                   }, null);
            }
            catch(InvalidAsynchronousStateException)
            {
                ; 
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void GameForm_Resize(object sender, EventArgs e)
        {
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
            pictureBox1.Location = new Point(0, 0);

           
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    //end game
                    RunningGame.End();
                    //close form
                    this.Close();
                    break;
                case Keys.D1:
                    RunningGame.SpawnUserGeneratedItem(MouseX,MouseY,PickUpType.Cannon);
                    break;
                case Keys.D2:
                    RunningGame.SpawnUserGeneratedItem(MouseX, MouseY, PickUpType.Flamethrower);
                    break;
                case Keys.D3:
                    RunningGame.SpawnUserGeneratedItem(MouseX, MouseY, PickUpType.RocketLauncher);
                    break;
                case Keys.D4:
                    RunningGame.SpawnUserGeneratedItem(MouseX, MouseY, PickUpType.Tentacles);
                    break;
                case Keys.D5:
                    RunningGame.SpawnUserGeneratedItem(MouseX, MouseY, PickUpType.Health);
                    break;
                case Keys.D6:
                    RunningGame.SpawnUserGeneratedItem(MouseX, MouseY, PickUpType.Shield);
                    break;
                case Keys.Space:
                    RunningGame.EscapeCurrentIntro();
                    break;

            }

           
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MouseX = e.X;
            MouseY = e.Y;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
