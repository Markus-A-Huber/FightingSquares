using GameTest.Game.GameElements;
using GameTest.Game.PickUps;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.MainFrame.GameModes
{
    class MoneyMaker : GameMode
    {
        int goal;
        Random Lucky;
        int TimeToNextCoin;
        public MoneyMaker(Game g, int Goal) : base(g)
        {
            this.goal = Goal;
            Lucky = new Random();
            TimeToNextCoin = Lucky.Next(100, 500);
        }

        public override bool checkWin(out Team Winner)
        {
            Winner = null;
            for (int i = 0; i < game.Teams.Count; i++)
            {
                if (game.Teams[i].TeamCoins > goal)
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
            g.DrawString("Money Maker (ESC to exit)", SystemFonts.DefaultFont, Brushes.Black, 10, 5);
            foreach (Team t in game.Teams.OrderByDescending(x => x.TeamCoins))
            {
                g.DrawString("Team " + (t.TeamNumber+1) + " : " + t.TeamCoins + " Coins", SystemFonts.DefaultFont, t.TeamColorBrush, 10, 20 + (counter) * 15);
                g.FillRectangle(Brushes.LightGray, 150, 28 + (counter) * 15, goal, 4);
                g.FillRectangle(t.TeamColorBrush, 150, 28 + (counter) * 15, t.TeamCoins, 4);
                counter++;
            }
            base.drawMenu(g);
        }
        public override void SpecialEvent()
        {
            if (TimeToNextCoin-- < 0)
            {
                lock (game.GameElementListLock)
                    game.GameElements.Add(new MoneyPickup(Lucky.Next(50, game.Width - 50), Lucky.Next(50, game.Height - 50), game));

                TimeToNextCoin = Lucky.Next(100, 500);
            }

        }

        internal override void showMissionObjective(Graphics g)
        {
            Font f = new Font("Arial", 11);
            g.FillEllipse(Brushes.White, game.Width / 2 - 100, game.Height / 2 - 100, 200, 200);
            g.DrawEllipse(Pens.Black, game.Width / 2 - 100, game.Height / 2 - 100, 200, 200);
            g.DrawString("GOAL of GAME", SystemFonts.CaptionFont, Brushes.Blue, game.Width / 2 - 65, game.Height / 2 - 30);
            g.DrawString("The team that first ", f, Brushes.Black, game.Width / 2 - 74, game.Height / 2 + 10);
            g.DrawString("collects " + goal.ToString() + " coins", f, Brushes.Black, game.Width / 2 - 70, game.Height / 2 + 30);
            g.DrawString("wins", f, Brushes.Black, game.Width / 2 - 15, game.Height / 2 + 50);

        }
    }
}
