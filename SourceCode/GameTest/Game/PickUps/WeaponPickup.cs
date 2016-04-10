using GameTest.Game.GameElements;
using GameTest.Game.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.PickUps
{
    abstract class WeaponPickup : PickUp
    {
        protected ConstructorInfo WeaponPrototype;
        protected Type WeaponType;
        public WeaponPickup(Type WeaponType, int x, int y, Game g) : base(x,y,30,30,g)
        {
            this.WeaponType = WeaponType;
            WeaponPrototype = WeaponType.GetConstructor(new Type[2] { typeof(Game), typeof(GameObject) });   
        }

        public virtual void changeWeaponOf(Fighter f)
        {
            if (TheGame.WeaponCeptionOn && f.CurrentWeapon != null && f.CurrentWeapon.AllowedUpgradesAndProbability.Keys.Contains(WeaponType))
            {
                if(Lucky.Next(0,100) < f.CurrentWeapon.AllowedUpgradesAndProbability[WeaponType])
                    f.CurrentWeapon.Upgrade = (Weapon)WeaponPrototype.Invoke(new object[] { TheGame, f });
                else
                    f.CurrentWeapon = (Weapon)WeaponPrototype.Invoke(new object[] { TheGame, f });
            }
            else
                f.CurrentWeapon = (Weapon)WeaponPrototype.Invoke(new object[] { TheGame, f });
        }

        public override PickUp interactWithFighter(Fighter f)
        {
            changeWeaponOf(f);
            return null;
        }
    }
}
