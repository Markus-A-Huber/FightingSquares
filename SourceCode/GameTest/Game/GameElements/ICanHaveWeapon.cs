using GameTest.Game.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest.Game.GameElements
{
    interface ICanHaveWeapon
    {
        Weapon CurrentWeapon { get; set; }
    }
}
