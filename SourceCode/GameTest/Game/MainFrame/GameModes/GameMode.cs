using GameTest.Game.GameElements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.MainFrame
{
    public abstract class GameMode
    {
        protected Game game;
        protected bool GameOver;
        protected Team Winner;
        public virtual bool checkWin(out Team Winner)
        {
            Winner = null;
            return false;
        }
        public GameMode(Game g)
        {
            game = g;
            GameOver = false;
        }
        public virtual void drawMenu(Graphics g)
        {
            if(GameOver)
            {
                g.FillEllipse(Brushes.White,game.Width / 2 - 100, game.Height / 2 - 100,200,200);
                g.DrawEllipse(Pens.Black, game.Width / 2 - 100, game.Height / 2 - 100, 200, 200);
                g.DrawString("GAME OVER", SystemFonts.CaptionFont, Brushes.Black, game.Width / 2 - 55, game.Height / 2 - 40);
                g.DrawString("Winner ", SystemFonts.CaptionFont, Brushes.Black, game.Width / 2 - 35, game.Height / 2);
                g.DrawString("TEAM "+(Winner.TeamNumber+1), SystemFonts.CaptionFont, Winner.TeamColorBrush, game.Width / 2 - 35, game.Height / 2 + 40);
            }
                
        }
        public virtual void SpecialEvent()
        {
            ;
        }

        internal virtual void showMissionObjective(Graphics g)
        {
            g.FillEllipse(Brushes.White, game.Width / 2 - 100, game.Height / 2 - 100, 200, 200);
            g.DrawEllipse(Pens.Black, game.Width / 2 - 100, game.Height / 2 - 100, 200, 200);
            g.DrawString("GOAL of GAME", SystemFonts.CaptionFont, Brushes.Blue, game.Width / 2 - 70, game.Height / 2 - 30);
            g.DrawString("No real goal, just fun.", SystemFonts.CaptionFont, Brushes.Black, game.Width / 2 - 90, game.Height / 2);    
        }
    }
}
