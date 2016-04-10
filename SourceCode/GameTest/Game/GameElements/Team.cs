using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.GameElements
{
    public class Team
    {
        public int TeamNumber { get; private set; }
        public int TeamKills { get; private set; }
        public int TeamCoins { get; private set; }
        private Color teamColor;
        public Color TeamColor
        {
            get
            {
                return teamColor;
            }
            private set
            {
                teamColor = value;
               TeamColorBrush = new SolidBrush(teamColor);
            }
        }
        public Brush TeamColorBrush { get; private set; }

        public Team(int Number, Color color)
        {
            TeamColor = color;
            TeamNumber = Number;
            TeamKills = 0;
        }

        public void addKill()
        {
            TeamKills++;
        }

        public void addCoin()
        {
            TeamCoins++;
        }

        internal void setColor(Color color)
        {
            TeamColor = color;
            TeamColorBrush = new SolidBrush(teamColor);
        }
    }
}
