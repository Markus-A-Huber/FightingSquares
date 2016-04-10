using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.Weapons
{
    class Flamethrower : Weapon
    {
        public Flamethrower(Game g, GameObject owner) : base(g, owner)
        {
        }
        public override void Shoot(int x, int y)
        {
            var bullet = new Bullet(i => 5 + i, 2, 25, 30, 30, owner.X - 2, owner.Y - 2, x, y, TheGame, owner.Team, System.Drawing.Brushes.OrangeRed);
            if (this.Upgrade != null)
            {
                bullet.CurrentWeapon = (Weapon)this.Upgrade.Clone();
                bullet.CurrentWeapon.owner = bullet;
            }
            TheGame.BulletElements.Add(bullet);
        }
    }
}
