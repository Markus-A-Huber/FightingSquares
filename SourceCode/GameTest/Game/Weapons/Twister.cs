using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.Weapons
{
    class Twister : Weapon
    {
        double TwistCount;
        public int TwistNumber { get; set; }
        public Twister(Game g, GameObject owner) : base(g, owner)
        {
            TwistCount = 0;
            TwistNumber = 3;
        }
        public override void Shoot(int x, int y)
        {
            TwistCount += 0.1;
            int xDir;
            int yDir;
            Bullet bullet;
            for (int i = 0; i < TwistNumber; i++)
            {
                xDir = (int)(owner.X  - 2 + 30 * Math.Sin(TwistCount % (2 * Math.PI) + i * 2 * Math.PI / TwistNumber));
                yDir = (int)(owner.Y  - 2 + 30 * Math.Cos(TwistCount % (2 * Math.PI) + i * 2 * Math.PI / TwistNumber));
                bullet = new Bullet(5, 15, 4, 4, owner.X  - 2, owner.Y  - 2, xDir, yDir, TheGame, owner.Team, System.Drawing.Brushes.Purple);
                bullet.speed = 10;
                TheGame.BulletElements.Add(bullet);
            }
        }
        
    }
}
