using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.Weapons
{
    public class Weapon
    {
        public Game TheGame { get; protected set; }
        public GameObject owner { get; set; }
        private int cooldown;
        protected int Cooldown
        {
            get
            {
                return cooldown;
            }
            set
            {
                cooldown = value;
            }
        }
        public Weapon Upgrade { get; set; }

        Dictionary<Type,int> allowedUpgradesAndProbability;
        public Dictionary<Type, int> AllowedUpgradesAndProbability
        {
            get
            {
                return allowedUpgradesAndProbability;
            }
            protected set
            {
                //make sure you only stack on other weapons 
                foreach (var t in value)
                {
                    if (t.Key.IsSubclassOf(typeof(Weapon)))
                        allowedUpgradesAndProbability.Add(t.Key,t.Value);
                    else
                        throw new ArgumentException("You can only stack Weapons on Weapons!");
                }
            }
        }

        public Weapon(Game g, GameObject owner)
        {
            TheGame = g;
            this.owner = owner;
            Cooldown = 10;
            Upgrade = null;
            allowedUpgradesAndProbability = new Dictionary<Type, int>();
        }
        
        public virtual void Shoot(int x, int y)
        {
            if (Cooldown-- < 0)
            {
                var bullet = new Bullet(owner.X, owner.Y, x, y, TheGame, owner.Team, Brushes.Black);
                bullet.Stoppable = false;
                if (this.Upgrade != null)
                {
                    bullet.CurrentWeapon = (Weapon)this.Upgrade.Clone();
                    bullet.CurrentWeapon.owner = bullet;
                }
                TheGame.BulletElements.Add(bullet);
                Cooldown = 10;
            }
        }
        /// <summary>
        /// Is not an exact copy. Will have some values erased which is necessary for operation in Weaponception
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            Weapon copy = (Weapon)this.MemberwiseClone();
            copy.Upgrade = null;
            //copy.TheGame = TheGame;
            copy.owner = null;
            copy.AllowedUpgradesAndProbability.Clear();
            //copy.Cooldown = cooldown;
            return copy;
        }
    }
}
