using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.Weapons
{
    class Pistol : Weapon
    {
        public Pistol(Game g, GameObject owner) : base(g,owner)
        {
            AllowedUpgradesAndProbability.Add(typeof(Cannon), 10);
            AllowedUpgradesAndProbability.Add(typeof(RocketLauncher), 10);
            AllowedUpgradesAndProbability.Add(typeof(Twister), 30);
            AllowedUpgradesAndProbability.Add(typeof(Wings), 30);
            AllowedUpgradesAndProbability.Add(typeof(Flamethrower), 30);
        }
    }
}
