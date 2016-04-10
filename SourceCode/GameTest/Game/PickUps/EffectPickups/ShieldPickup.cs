using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.PickUps
{
    class ShieldPickup : PickUp
    {
        PickUp EmbeddedPickup;
        int LifeTime;
        public ShieldPickup(int x, int y, Game g) : base(x,y,30,30,g)
        {
            LifeTime = 500;
            EmbeddedPickup = null;
        }

        public override void draw(Graphics g)
        {
            g.DrawImage(Images.ShieldPickup, X-Width/2, Y-Height/2, Width, Height);
        }

        public override PickUp interactWithFighter(Fighter f)
        {
            if(LifeTime-- > 0)
            {
                f.Shielded = true;
                if(EmbeddedPickup != null)
                    EmbeddedPickup = EmbeddedPickup.interactWithFighter(f);
                return this;
            }
            else
            {
                f.Shielded = false;
                if (EmbeddedPickup != null)
                    return EmbeddedPickup;
                else
                    return null;
            }
        }

        public override PickUp reactToNewPickup(PickUp p)
        {
            if (LifeTime-- <= 0)
                return p;
            else
            {
                if (p is ShieldPickup)
                    LifeTime += 500; //if its a shield increase the shielding time
                else
                    EmbeddedPickup = p; //save other pickup

                return this;
            }
        }
    }
}
