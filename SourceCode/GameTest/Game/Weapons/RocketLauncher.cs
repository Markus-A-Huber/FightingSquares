using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.Weapons
{
    class RocketLauncher : Weapon
    {
        public RocketLauncher(Game g, GameObject owner) : base(g, owner)
        {
            Cooldown = 30;
            //Set stackable Weapons with according probability
            AllowedUpgradesAndProbability.Add(typeof(Twister), 100);
            AllowedUpgradesAndProbability.Add(typeof(Tentacles), 100);
            AllowedUpgradesAndProbability.Add(typeof(Wings), 100);
            AllowedUpgradesAndProbability.Add(typeof(Cannon), 1); //crazy
            AllowedUpgradesAndProbability.Add(typeof(Pistol), 100);
            AllowedUpgradesAndProbability.Add(typeof(Flamethrower), 100);
        }
        public override void Shoot(int x, int y)
        {
            if (Cooldown-- < 0)
            {
                var bullet = new Explosive(1000, 30, 5, 5, owner.X - 2, owner.Y - 2, x, y, TheGame, owner.Team, System.Drawing.Brushes.Red);
                if (this.Upgrade != null)
                {
                    bullet.CurrentWeapon = (Weapon)this.Upgrade.Clone();
                    bullet.CurrentWeapon.owner = bullet;
                }
                bullet.Stoppable = false;
                TheGame.BulletElements.Add(bullet);
                Cooldown = 70;
            }
        }
    }
}
