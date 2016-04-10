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
    public partial class StartMenu : Form
    {
        public Game.Game ChosenGame { get; private set; }
        public WindowStyle WinStyle = WindowStyle.WinForms;
        public StartMenu()
        {
            InitializeComponent(); 
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void StartGameWinForms_Click(object sender, EventArgs e)
        {
            //ChosenGame = new Game.Game(RendererSpeed.Value,gameLoopSpeed.Value,NoOfFighters.Value,RespawnScroller.Value,NumberOfTeamsScroller.Value,PickupScroller.Value,checkStatistics.Checked);
            WinStyle = WindowStyle.WinForms;
            DialogResult = DialogResult.OK;
        }

        private void GameStartWPF_Click(object sender, EventArgs e)
        {
            //ChosenGame = new Game.Game(RendererSpeed.Value, gameLoopSpeed.Value, NoOfFighters.Value, RespawnScroller.Value, NumberOfTeamsScroller.Value, PickupScroller.Value, checkStatistics.Checked);
            WinStyle = WindowStyle.WPF;
            DialogResult = DialogResult.OK;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
