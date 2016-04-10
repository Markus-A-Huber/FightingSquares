using GameTest.Game.Weapons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.PickUps
{
    class RocketLauncherPickup : WeaponPickup
    {
        public RocketLauncherPickup(int x, int y, Game g) : base(typeof(RocketLauncher),x, y, g)
        {
        }

        public override void draw(Graphics g)
        {
            g.DrawImage(Images.RocketLauncherPickup, X-Width/2, Y-Height/2, Width, Height);
        }

    }
}
