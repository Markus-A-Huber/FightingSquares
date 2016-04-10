using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.Weapons
{
    class Tentacles : Weapon
    {
        public Tentacles(Game g, GameObject owner) : base(g, owner)
        {
        }
        public override void Shoot(int x, int y)
        {
            TheGame.BulletElements.Add(new Bullet(i => 20 -i, 7, 15, 30, 30, owner.X , owner.Y ,
                                                x, y,
                                                TheGame, owner.Team, System.Drawing.Brushes.ForestGreen));
            TheGame.BulletElements.Add(new Bullet(i => 20 - i, 7, 15, 30, 30, owner.X, owner.Y,
                                                owner.X * 2 - x, owner.Y * 2 - y,
                                                TheGame, owner.Team, System.Drawing.Brushes.ForestGreen));
            TheGame.BulletElements.Add(new Bullet(i => 20 - i, 7, 15, 30, 30, owner.X, owner.Y,
                                                owner.X *2 - x, y, 
                                                TheGame, owner.Team, System.Drawing.Brushes.ForestGreen));
            TheGame.BulletElements.Add(new Bullet(i => 20 - i, 7, 15, 30, 30, owner.X, owner.Y,
                                                x, owner.Y * 2 - y,
                                                TheGame, owner.Team, System.Drawing.Brushes.ForestGreen));
        }
    }
}
