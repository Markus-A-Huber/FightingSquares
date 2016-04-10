using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.PickUps
{
    class HealthPickup : PickUp
    {
        public HealthPickup(int x, int y, Game g) : base(x,y,30,30,g)
        {
            
        }
        
        public override void draw(Graphics g)
        {
            g.DrawImage(Images.HealthPickup, X - Width / 2, Y - Height / 2, Width, Height);
        }

        public override PickUp interactWithFighter(Fighter f)
        {
            f.HP += 50;
            return null;
        }
    }
}
