using GameTest.Game.GameElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameTest.Game.MainFrame.GameModes
{
    class Deathmatch : GameMode
    {
        int goal;
        public Deathmatch(Game g, int Goal) : base(g)
        {
            this.goal = Goal;
        }

        public override bool checkWin(out Team Winner)
        {
            Winner = null;
            for(int i=0;i<game.Teams.Count;i++)
            {
                if (game.Teams[i].TeamKills > goal)
                {
                    this.Winner = game.Teams[i];
                    Winner = this.Winner;
                    GameOver = true;
                    return true;
                }
            }
            return false;
        }
        public override void drawMenu(Graphics g)
        {
            int counter = 0;
            g.DrawString("Team Deathmatch (ESC to exit)", SystemFonts.DefaultFont, Brushes.Black, 10, 5);
            foreach (Team t in game.Teams.OrderByDescending(x => x.TeamKills))
            {
                g.DrawString("Team " + (t.TeamNumber+1) + " : " + t.TeamKills + " Kills", SystemFonts.DefaultFont, t.TeamColorBrush, 10, 20 + (counter) * 15);
                g.FillRectangle(Brushes.LightGray, 140, 28 + (counter) * 15, goal, 4);
                g.FillRectangle(t.TeamColorBrush, 140, 28 + (counter) * 15, t.TeamKills, 4);
                counter++;
            }
            base.drawMenu(g);
        }

        internal override void showMissionObjective(Graphics g)
        {
            Font f = new Font("Arial", 11);
            g.FillEllipse(Brushes.White, game.Width / 2 - 100, game.Height / 2 - 100, 200, 200);
            g.DrawEllipse(Pens.Black, game.Width / 2 - 100, game.Height / 2 - 100, 200, 200);
            g.DrawString("GOAL of GAME", SystemFonts.CaptionFont, Brushes.Blue, game.Width / 2 - 65, game.Height / 2 - 30);
            g.DrawString("The team that first ", f, Brushes.Black, game.Width / 2 - 74, game.Height / 2+10);
            g.DrawString("shoots "+goal.ToString()+" enemies", f, Brushes.Black, game.Width / 2 - 78, game.Height / 2+30);
            g.DrawString("wins", f, Brushes.Black, game.Width / 2 - 15, game.Height / 2 + 50);

        }
    }
}
