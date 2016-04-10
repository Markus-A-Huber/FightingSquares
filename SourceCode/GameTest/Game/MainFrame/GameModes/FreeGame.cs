using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.MainFrame.GameModes
{
    class FreeGame : GameMode
    {
        public FreeGame(Game g) :base(g)
        {

        }
        public override void drawMenu(Graphics g)
        {
            g.DrawString("Free Roam Mode (ESC to exit)", SystemFonts.DefaultFont, Brushes.Black, 10, 20);
            base.drawMenu(g);
        }
    }
}
