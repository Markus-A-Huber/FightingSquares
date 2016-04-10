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

namespace GameTest.WindowsForms.GameBuilderForm.UserControls
{
    public partial class TeamStrip : UserControl
    {
        private Team TeamNumber;
        List<CustomizeBotControl> BotControls;
        List<CustomizePlayerControl> PlayerControls;
        Game.Game TheGame;
        public TeamStrip(Team Teamnumber, Game.Game g)
        {
            InitializeComponent();
            TeamNumber = Teamnumber;
            TeamName.Text = "Team " + TeamNumber;
            BotControls = new List<CustomizeBotControl>();
            PlayerControls = new List<CustomizePlayerControl>();
            TheGame = g;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = new CustomizePlayerControl(TheGame,TeamNumber);
           
            tableLayoutPanel3.Controls.Add(p,tableLayoutPanel3.ColumnCount,0);
            
            tableLayoutPanel3.SetRowSpan(p, 2);
            PlayerControls.Add(p);

        }

        private void AddBot_Click(object sender, EventArgs e)
        {
            var p = new CustomizeBotControl(TheGame,TeamNumber);
            
            tableLayoutPanel3.Controls.Add(p, tableLayoutPanel3.ColumnCount, 0);
            tableLayoutPanel3.SetRowSpan(p, 2);
            BotControls.Add(p);
        }

        private void TeamColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                TeamColor.BackColor = cd.Color;
                TeamNumber.setColor(cd.Color);

            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public List<Fighter> returnBots()
        {
            List<Fighter> Elements = new List<Fighter>();
            foreach (CustomizeBotControl Control in BotControls)
                Elements.AddRange(Control.returnBots());

            return Elements;
        }

        public List<Player> returnPlayers()
        {
            List<Player> Elements = new List<Player>();
            foreach (CustomizePlayerControl Control in PlayerControls)
                Elements.Add(Control.returnPlayer());

            return Elements;
        }
    }
}
