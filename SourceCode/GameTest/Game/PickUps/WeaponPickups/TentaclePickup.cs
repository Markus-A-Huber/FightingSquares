using GameTest.Game.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameTest.Game.PickUps
{
    class TentaclePickup : WeaponPickup
    {
        public TentaclePickup(int x, int y, Game g) : base(typeof(Tentacles),x, y, g)
        {
        }

        public override void draw(Graphics g)
        {
            g.DrawImage(Images.TentaclePickup, X-Width/2, Y-Height/2, Width, Height);
        }
    }
}
