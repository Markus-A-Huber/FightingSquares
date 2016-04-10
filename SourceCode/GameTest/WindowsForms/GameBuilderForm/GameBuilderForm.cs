using GameTest.Game;
using GameTest.Game.GameElements;
using GameTest.Game.MainFrame.GameModes;
using GameTest.Game.PickUps;
using GameTest.WindowsForms.GameBuilderForm.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTest.WindowsForms.GameBuilderForm
{
    public partial class GameBuilderForm : Form
    {
        int Teamnumber;
        List<TeamStrip> AllTeams;
        List<Team> Teams;
        Game.Game TheGame;
        public GameForm ChosenGame { get; private set; }

        public GameBuilderForm()
        {
            Teams = new List<Team>();
            TheGame = new Game.Game(10, 10, 10, 10, false,false);
            TheGame.Width = Screen.PrimaryScreen.WorkingArea.Width;
            TheGame.Height = Screen.PrimaryScreen.WorkingArea.Height;
            //WindowState = FormWindowState.Maximized;
            InitializeComponent();
            Teamnumber = 0;
            AllTeams = new List<TeamStrip>();

            //Add a first Team
            button1_Click(this, EventArgs.Empty);

            tableLayoutPanel1.Padding = new Padding(4);

            GameMode.SelectedIndex = 1;
            Points.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void teamStrip1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Add Team
        private void button1_Click(object sender, EventArgs e)
        {
            Teams.Add(new Game.GameElements.Team(Teamnumber, Color.Red));
            var newTeam = new TeamStrip(Teams[Teams.Count-1],TheGame);
            AllTeams.Add(newTeam);
            Teamnumber++;
            int rows = tableLayoutPanel1.RowCount; 
            tableLayoutPanel1.Controls.Add(newTeam,0,rows-2);
            

            //tableLayoutPanel1.RowCount+;
            //tableLayoutPanel1.SetRow(newTeam, 3);//rows-Teamnumber-3);
        }
        //Start Game
        private void button2_Click(object sender, EventArgs e)
        {
            List<Player> Players = new List<Player>();
            List<Fighter> Bots = new List<Fighter>();
            foreach (var ts in AllTeams)
            {
                Players.AddRange(ts.returnPlayers());
                Bots.AddRange(ts.returnBots());
            }

            //Goal
            int points = 0;
            switch (Points.SelectedIndex)
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
                    TheGame.PlayMode = new FreeGame(TheGame);
                    break;
                case 1:
                    TheGame.PlayMode = new Deathmatch(TheGame, points);
                    break;
                case 2:
                    TheGame.PlayMode = new MoneyMaker(TheGame, points);
                    break;
            }


            TheGame.changeStartParameters(RendererSpeed.Value, gameLoopSpeed.Value, RespawnScroller.Value, PickupScroller.Value,WeaponceptionCheckbox.Checked, checkStatistics.Checked);
            TheGame.Teams = Teams;

            //add the Pickups which were checked
            if (HealthCheckbox.Checked)
                TheGame.PickupManager.AddAvailablePickups(PickUpType.Health);
            if (ShieldCheckbox.Checked)
                TheGame.PickupManager.AddAvailablePickups(PickUpType.Shield);
            if (CannonCheckbox.Checked)
                TheGame.PickupManager.AddAvailablePickups(PickUpType.Cannon);
            if (FlameCheckbox.Checked)
                TheGame.PickupManager.AddAvailablePickups(PickUpType.Flamethrower);
            if (RocketCheckbox.Checked)
                TheGame.PickupManager.AddAvailablePickups(PickUpType.RocketLauncher);
            if (TentacleCheckbox.Checked)
                TheGame.PickupManager.AddAvailablePickups(PickUpType.Tentacles);
            if (TwisterCheckbox.Checked)
                TheGame.PickupManager.AddAvailablePickups(PickUpType.Twister);
            if (WingsCheckbox.Checked)
                TheGame.PickupManager.AddAvailablePickups(PickUpType.Wings);

            ChosenGame = new GameForm(TheGame, Players, Bots);

            DialogResult = DialogResult.OK;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
