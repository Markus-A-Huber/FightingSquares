using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.PickUps
{
    class MoneyPickup : PickUp
    {
        public MoneyPickup(int x, int y, Game g) : base(x,y,30,30,g)
        {

        }

        public override void draw(Graphics g)
        {
            g.DrawImage(Images.MoneyPickup, X - Width / 2, Y - Height / 2, Width, Height);
        }

        public override PickUp interactWithFighter(Fighter f)
        {
            f.Team.addCoin();
            IsDead = true;
            return null;
        }
    }
}
