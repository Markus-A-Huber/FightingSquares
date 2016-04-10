using GameTest.Game.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.Weapons
{
    class Cannon : Weapon
    {
        public Cannon(Game g, GameObject owner) : base(g,owner)
        {
            Cooldown = 50;
            //Set stackable Weapons with according probability
            AllowedUpgradesAndProbability.Add(typeof(Twister),100);
            AllowedUpgradesAndProbability.Add(typeof(Tentacles),100);
            AllowedUpgradesAndProbability.Add(typeof(Wings),100);
            AllowedUpgradesAndProbability.Add(typeof(RocketLauncher),1); //crazy
            AllowedUpgradesAndProbability.Add(typeof(Pistol),100);
        }
        public override void Shoot(int x, int y)
        {
            if (Cooldown-- < 0)
            {
                var bullet = new Bullet(10, 100, 30, 30, owner.X  - 15, owner.Y  - 15, x, y, TheGame, owner.Team, System.Drawing.Brushes.Black);
                bullet.Stoppable = false;
                if (this.Upgrade != null)
                {
                    bullet.CurrentWeapon = (Weapon)this.Upgrade.Clone();
                    bullet.CurrentWeapon.owner = bullet;  
                }
                TheGame.BulletElements.Add(bullet);
                Cooldown = 50;
            }
        }
    }
}
