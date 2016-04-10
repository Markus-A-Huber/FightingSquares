using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.Weapons
{
    class Wings : Weapon
    {
        double TwistCount;
        public Wings(Game g, GameObject owner) : base(g, owner)
        {
            TwistCount = 0;
        }

        public override void Shoot(int x, int y)
        {
            TwistCount += 0.1;
            for(int i = 0; i<4;i++)
            {
                int xDir = (int)(owner.X - 3 + 30 * Math.Sin(TwistCount % (2 * Math.PI ) + i * Math.PI/2 ));
                int yDir = (int)(owner.Y - 3 + 30 * Math.Cos(TwistCount % (2 * Math.PI ) - i*Math.PI/2  ));
                var bullet = new Bullet(5, 15, 6, 6, owner.X - 1, owner.Y - 1, xDir, yDir, TheGame, owner.Team, System.Drawing.Brushes.Orange);
                bullet.speed = 10;
                TheGame.BulletElements.Add(bullet);
            }
            /*
            int xDir = (int)(owner.X - 3 + 30 * Math.Sin(TwistCount % (2 * Math.PI)));
            int yDir = (int)(owner.Y - 3 + 30 * Math.Cos(TwistCount % (2 * Math.PI)));
            var bullet = new Bullet(5, 15, 6, 6, owner.X  - 1, owner.Y  - 1, xDir, yDir, TheGame, owner.Team, System.Drawing.Brushes.Orange);
            bullet.speed = 10;
            TheGame.GameElements.Add(bullet);
            xDir = (int)(owner.X  - 3 - 30 * Math.Sin(TwistCount % (2 * Math.PI)));
            yDir = (int)(owner.Y  - 3 - 30 * Math.Cos(TwistCount % (2 * Math.PI)));
            bullet = new Bullet(5, 15, 6, 6, owner.X  - 1, owner.Y - 1, xDir, yDir, TheGame, owner.Team, System.Drawing.Brushes.Orange);
            bullet.speed = 10;
            TheGame.GameElements.Add(bullet);
            xDir = (int)(owner.X  - 3 + 30 * Math.Sin(TwistCount % (2 * Math.PI)));
            yDir = (int)(owner.Y  - 3 - 30 * Math.Cos(TwistCount % (2 * Math.PI)));
            bullet = new Bullet(5, 15, 6, 6, owner.X  - 1, owner.Y  - 1, xDir, yDir, TheGame, owner.Team, System.Drawing.Brushes.Orange);
            bullet.speed = 10;
            TheGame.GameElements.Add(bullet);
            xDir = (int)(owner.X  - 3 - 30 * Math.Sin(TwistCount % (2 * Math.PI)));
            yDir = (int)(owner.Y  - 3 + 30 * Math.Cos(TwistCount % (2 * Math.PI)));
            bullet = new Bullet(5, 15, 6, 6, owner.X  - 1, owner.Y  - 1, xDir, yDir, TheGame, owner.Team, System.Drawing.Brushes.Orange);
            bullet.speed = 10;
            TheGame.GameElements.Add(bullet);*/
        }
        
    }
}
