using GameTest.Game.Weapons;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.PickUps
{
    class TwisterPickup : WeaponPickup
    {
        public TwisterPickup(int x, int y, Game g) : base(typeof(Twister),x,y,g)
        {
        }

        public override void changeWeaponOf(Fighter f)
        {
            if (TheGame.WeaponCeptionOn && f.CurrentWeapon is Twister)
                ((Twister)f.CurrentWeapon).TwistNumber += 2;
            else
            {
                base.changeWeaponOf(f);
            }
        }

        public override void draw(Graphics g)
        {
            g.DrawImage(Images.TwisterPickup, X-Width/2, Y-Height/2, Width, Height);
        }

    }
}
